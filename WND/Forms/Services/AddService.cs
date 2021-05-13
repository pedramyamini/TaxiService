using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using Models;
using Utility;

namespace WND
{
    public partial class AddService : Form
    {

        IEnumerable<Models.Customer> CustomersList;
        IEnumerable<Models.Path> PathsList;
        IEnumerable<Models.Driver> DriversList;
        public AddService()
        {
            InitializeComponent();
        }

        private void AddService_Load(object sender, EventArgs e)
        {
            try
            {
                //auto complement of customers
                CustomersList = TaxiDbContext.Instance.Users.OfType<Models.Customer>().ToList();
                AutoCompleteStringCollection customersSource = new AutoCompleteStringCollection();
                customersSource.AddRange(CustomersList.Select(c => c.FullName).ToArray());
                txtCustomer.AutoCompleteCustomSource = customersSource;

                //paths combobox binding
                PathsList=TaxiDbContext.Instance.Paths.ToList();
                comboboxPaths.Items.AddRange(PathsList.Select(p=>p.Origin+" - "+p.Destination).ToArray());

                //drivers combobox binding
                DriversList = TaxiDbContext.Instance.Users.OfType<Models.Driver>().ToList();
                comboboxDrivers.Items.AddRange(DriversList.Select(d=>d.FullName).ToArray());
            }
            catch
            {

            }
            

            
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if(comboboxDrivers.SelectedItem==null
                || comboboxPaths.SelectedItem==null
                || string.IsNullOrEmpty(txtCustomer.Text))
            {
                MessageBoxRTL.Error("انتخاب مشتری، راننده و مسیر الزامی می‌باشد.", string.Empty);
                return;
            }
            int Delay = 0;
            int.TryParse(txtDelay.Text.PersianToEnglish(), out Delay);
            int Amount = 0;
            int.TryParse(txtCost.Text.PersianToEnglish(), out Amount);
            Models.Service service = new Models.Service()
            {
                DateTime = DateTime.Now,
                Delay = Delay,
                OriginInDetail = txtOriginInDetail.Text,
                DestinationInDetail = txtDestinationInDetail.Text,
                IsActive = true,
                Transaction = new Models.Transaction()
                {
                    Amount = Amount,
                    IsPaid = checkboxIsPaid.Checked
                },
                Driver = DriversList.SingleOrDefault(d => d.FullName == comboboxDrivers.SelectedItem.ToString())
                , Customer = CustomersList.SingleOrDefault(c => c.FullName == txtCustomer.Text)
                , ServicePaths = new List<ServicePath>()
                {
                    new ServicePath()
                    {
                        Path = PathsList.SingleOrDefault(p => p.OriginDestination == comboboxPaths.SelectedItem.ToString())
                    }
                },
                IsDeleted = false
            };
            if(Validation.Validate(service))
            {
                try
                {
                    TaxiDbContext.Instance.Services.Add(service);
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info("افزودن سرویس با موفقیت انجام شد", string.Empty);
                }
                catch
                {
                    MessageBoxRTL.Error("افزودن سرویس با خطا روبرو شد", string.Empty);
                }
            }
        }

        private void comboboxPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedPath=comboboxPaths.SelectedItem.ToString().Split('-');
            Models.Path path=PathsList.Where(p => p.Origin == selectedPath[0].Trim() && p.Destination == selectedPath[1].Trim()).Select(p => p).SingleOrDefault();
            txtCost.Text = path.Cost.ToString();
        }

        private void comboboxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Car car = DriversList.Where(d => d.FullName == comboboxDrivers.SelectedItem.ToString()).Select(d => d.Car).SingleOrDefault();
            txtCar.Text = string.Format("مدل: {0} پلاک: {1} رنگ: {2}",car.Model,car.LicensePlate,car.Color);
        }
    }
}
