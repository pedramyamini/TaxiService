using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using WND.Models;
using WND.Models.ViewModels;
using WND.Utility;

namespace WND
{
    public partial class EditService : Form
    {
        Models.Service service;
        ITaxiDbContext taxiContext;
        Form sourceForm;

        IEnumerable<Models.Customer> CustomersList;
        IEnumerable<Models.Path> PathsList;
        IEnumerable<Models.Driver> DriversList;
        public EditService(ITaxiDbContext _taxiContext)
        {
            InitializeComponent();
            taxiContext = _taxiContext;
        }

        public EditService(ITaxiDbContext _taxiContext, Form _sourceForm)
        {
            InitializeComponent();
            taxiContext = _taxiContext;
            sourceForm = _sourceForm;

            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern;
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            FillServicesGrid();

            try
            {
                //auto complement of customers
                CustomersList = taxiContext.Users.OfType<Models.Customer>().ToList();
                AutoCompleteStringCollection customersSource = new AutoCompleteStringCollection();
                customersSource.AddRange(CustomersList.Select(c => c.FullName).ToArray());
                txtCustomer.AutoCompleteCustomSource = customersSource;

                //paths combobox binding
                PathsList = taxiContext.Paths.ToList();
                comboboxPaths.Items.AddRange(PathsList.Select(p => p.Origin + " - " + p.Destination).ToArray());

                //drivers combobox binding
                DriversList = taxiContext.Users.OfType<Models.Driver>().ToList();
                comboboxDrivers.Items.AddRange(DriversList.Select(d => d.FullName).ToArray());

                //Search Feed
                List<string> SearchFeed=new List<string>();
                SearchFeed.AddRange(CustomersList.Select(c => c.FullName));
                SearchFeed.AddRange(CustomersList.Select(c => c.Mobile));
                SearchFeed.AddRange(DriversList.Select(d => d.FullName));
                SearchFeed.AddRange(DriversList.Select(d => d.Mobile));
                SearchFeed.AddRange(PathsList.Select(p => p.OriginDestination));
                AutoCompleteStringCollection AutoCompleteSearch = new AutoCompleteStringCollection();
                AutoCompleteSearch.AddRange(SearchFeed.ToArray());
                txtSearch.AutoCompleteCustomSource = AutoCompleteSearch;
            }
            catch
            {

            }
        }

        private void ClearForm()
        {
            List<TextBox> TextBoxes = this.Controls.OfType<TextBox>().ToList();
            TextBoxes.ForEach(t => t.ResetText());
            List<RichTextBox> RichTextBoxes = this.Controls.OfType<RichTextBox>().ToList();
            RichTextBoxes.ForEach(r => r.ResetText());
            List<ComboBox> ComboBoxes = this.Controls.OfType<ComboBox>().ToList();
            ComboBoxes.ForEach(c => c.ResetText());
            List<CheckBox> CheckBoxes = this.Controls.OfType<CheckBox>().ToList();
            CheckBoxes.ForEach(c => c.Checked = false);
        }

        private void FillServicesGrid()
        {
            datagridServices.AutoGenerateColumns = true;
            List<VMService> services = new List<VMService>();


            DateTime TodayStart = dateTimePicker1.Value; //Today at 00:00:00
            DateTime TodayEnd = TodayStart.AddDays(1).AddTicks(-1); //Today at 23:59:59

            var TodayServices = taxiContext.Services
                .Where(s => s.DateTime >= TodayStart && s.DateTime <= TodayEnd && !s.IsDeleted)
                .OrderByDescending(s => s.DateTime).ToList();

            //Search
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                string Search = txtSearch.Text;
                TodayServices=TodayServices.Where(s => s.Customer.FullName.Contains(Search)
                || s.Customer.Mobile.Contains(Search.PersianToEnglish())
                || s.Driver.FullName.Contains(Search)
                || s.Driver.Mobile.Contains(Search.PersianToEnglish())
                || s.ServicePaths.First().Path.OriginDestination.Contains(Search)
                ).ToList();
            }
            TodayServices
                .ForEach(s =>
                {
                    services.Add(
                         new VMService()
                         {
                             Id = s.Id,
                             CustomerFullName = s.Customer.FullName,
                             CustomerMobile = s.Customer.Mobile,
                             Path = s.ServicePaths.First().Path.OriginDestination,
                             DriverFullName = s.Driver.FullName,
                             DriverMobile = s.Driver.Mobile,
                             Cost = s.Transaction.Amount,
                             IsPaid = s.Transaction.IsPaid,
                             DateTime = s.DateTime
                         }
                    );
                });
            datagridServices.DataSource = services;
            datagridServices.Columns[0].Visible = false;


        }

        private void FillForm()
        {
            if (datagridServices.SelectedCells.Count == 1 || datagridServices.SelectedRows.Count == 1)
            {
                int Id = int.Parse(datagridServices.CurrentRow.Cells[0].Value.ToString());
                service = taxiContext.Services.Single(s =>
                    s.Id == Id);

                ClearForm();

                txtCustomer.Text = service.Customer.FullName;
                txtOriginInDetail.Text = service.OriginInDetail;
                txtDestinationInDetail.Text = service.DestinationInDetail;
                txtDelay.Text = service.Delay.ToString();
                txtCar.Text = string.Format("مدل: {0} پلاک: {1} رنگ: {2}", service.Driver.Car.Model, service.Driver.Car.LicensePlate,
                    service.Driver.Car.Color);
                txtCost.Text = service.Transaction.Amount.ToString();
                comboboxPaths.SelectedText = service.ServicePaths.First().Path.OriginDestination;
                comboboxDrivers.SelectedText = service.Driver.FullName;
                checkboxIsPaid.Checked = service.Transaction.IsPaid;
            }
        }

        private void EditService_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

        }

        private void btnEditService_Click(object sender, EventArgs e)
        {


            if (comboboxDrivers.Text == null ||
                comboboxPaths.Text == null ||
                string.IsNullOrEmpty(txtCustomer.Text))
            {
                MessageBoxRTL.Error("فیلدهای مشتری، مسیر و راننده نمی‌تواند خالی باشد.", string.Empty);
                return;
            }
            DialogResult dr = MessageBoxRTL.Ask("آیا از ویرایش سرویس اطمینان دارید؟", string.Empty);
            if (Validation.Validate(service) && dr == DialogResult.Yes)
            {
                taxiContext.Services.Attach(service);

                int Delay = service.Delay;
                int.TryParse(txtDelay.Text.PersianToEnglish(), out Delay);

                int Amount = service.Transaction.Amount;
                int.TryParse(txtCost.Text.PersianToEnglish(), out Amount);

                service.Customer = CustomersList.SingleOrDefault(c => c.FullName == txtCustomer.Text);
                service.Driver = DriversList.SingleOrDefault(d => d.FullName == comboboxDrivers.Text.ToString());
                service.OriginInDetail = txtOriginInDetail.Text;
                service.DestinationInDetail = txtDestinationInDetail.Text;
                service.ServicePaths.First().Path = PathsList.SingleOrDefault(p => p.OriginDestination == comboboxPaths.Text.ToString());
                service.Delay = Delay;
                service.Transaction.Amount = Amount;
                service.Transaction.IsPaid = checkboxIsPaid.Checked;


                taxiContext.SaveChanges();

                FillServicesGrid();

                MessageBoxRTL.Info("ویرایش سرویس با موفقیت انجام شد.", string.Empty);

            }



        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از حذف سرویس اطمینان دارید؟", string.Empty);
            if (datagridServices.SelectedRows.Count == 1 || datagridServices.SelectedCells.Count == 1 && dr==DialogResult.Yes)
            {
                try
                {
                    var Id = int.Parse(datagridServices.CurrentRow.Cells[0].Value.ToString());
                    taxiContext.Services.Find(Id).IsDeleted = true;
                    taxiContext.SaveChanges();
                    FillServicesGrid();
                    MessageBoxRTL.Info("حذف سرویس با موفقیت انجام شد.", string.Empty);
                }
                catch
                {
                    MessageBoxRTL.Info("حذف سرویس با خطا روبرو شد.", string.Empty);
                }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void datagridServices_SelectionChanged(object sender, EventArgs e)
        {
            FillForm();
        }

        private void datagridServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillForm();
        }

        private void comboboxPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedPath = comboboxPaths.SelectedItem.ToString().Split('-');
            Models.Path path = PathsList.Where(p => p.Origin == selectedPath[0].Trim() && p.Destination == selectedPath[1].Trim()).Select(p => p).SingleOrDefault();
            txtCost.Text = path.Cost.ToString();
        }

        private void comboboxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Car car = DriversList.Where(d => d.FullName == comboboxDrivers.SelectedItem.ToString()).Select(d => d.Car).SingleOrDefault();
            txtCar.Text = string.Format("مدل: {0} پلاک: {1} رنگ: {2}", car.Model, car.LicensePlate, car.Color);
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillServicesGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillServicesGrid();
        }

        private void EditService_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {
                sourceForm.Enabled = true;
                sourceForm.Focus();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
