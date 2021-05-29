using BaseFormLibrary;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using WND.Data;
using WND.Forms;

namespace WND.Forms
{
    public partial class frmCustomers : BaseForm
    {
        bool Searching = false;

        List<Models.Service> ActiveServices = new List<Models.Service>();
        int CurrentActiveService = 0;

        private Models.Customer initialBizObject = new Models.Customer()
        {
            Id = 0,
            FullName = string.Empty,
            Mobile = string.Empty,
            Address = string.Empty
        };
        private Models.Customer bizObject { get; set; }

        private Models.Customer BizObject
        {
            set
            {

                if (value == null)
                {

                    bizObject = new Models.Customer()
                    {
                        Id = 0,
                        FullName = string.Empty,
                        Mobile = string.Empty,
                        Address = string.Empty,
                        Role = Roles.Customer
                    };

                    this.Controls.OfType<SizableTextBox>().ToList().ForEach(t => t.ResetText());
                    this.Controls.OfType<NumericTextBox>().ToList().ForEach(t => t.ResetText());
                    lbl1.ResetText();
                    lblLastCost.ResetText();
                    lblLastOrigin.ResetText();
                    lblLastDestination.ResetText();
                    lblTotalCost.ResetText();
                    lblTotalServices.ResetText();
                    lbl1.Text = "مسافرت‌های";

                    //gridCustomers.ClearSelection();
                }
                else
                {
                    bizObject = value;
                }

                txtCustomerFullName.DataBindings.Clear();
                txtCustomerFullName.DataBindings.Add("Text", bizObject, nameof(Models.Customer.FullName));

                lblCustomerName.DataBindings.Clear();
                lblCustomerName.DataBindings.Add("Text", txtCustomerFullName, "Text");

                txtCustomerPhone.DataBindings.Clear();
                txtCustomerPhone.DataBindings.Add("Text", bizObject, nameof(Models.Customer.Mobile));


                txtCustomerAddress.DataBindings.Clear();
                txtCustomerAddress.DataBindings.Add("Text", bizObject, nameof(Models.Customer.Address));

                if (BizObject.Id != 0 && BizObject.Role == Roles.Customer && BizObject.Services.Where(s=>!s.IsDeleted).ToList().Count > 0)
                {
                    ActiveServices = TaxiDbContext.Instance.Services.Where(s => !s.IsDeleted && s.CustomerId==BizObject.Id)
                        .Include(s => s.Transaction).Include(s => s.ServicePaths)
                        .OrderByDescending(s => s.DateTime).ToList();
                    Service service = ActiveServices.First(s=>s.CustomerId == BizObject.Id && !s.IsDeleted);

                    CurrentActiveService = 0;
                    
                    //lblLastCost.DataBindings.Clear();
                    //lblLastCost.DataBindings.Add("Text", service.Transaction , nameof(Transaction.Amount));
                    lblLastCost.Text = (service.Transaction.Amount / 1000).ToString();

                    var pathId = service.ServicePaths.First().PathId;
                    Path path = TaxiDbContext.Instance.Paths.Single(p=>p.Id == pathId);
                    lblLastOrigin.DataBindings.Clear();
                    lblLastOrigin.DataBindings.Add("Text", path, nameof(Models.Path.Origin));

                    lblLastDestination.DataBindings.Clear();
                    lblLastDestination.DataBindings.Add("Text", path, nameof(Models.Path.Destination));

                    
                    var TotalCost = TaxiDbContext.Instance.Services.Where(s=>!s.IsDeleted &&  s.CustomerId== BizObject.Id).Sum(s => s.Transaction.Amount);
                    lblTotalCost.Text = TotalCost.ToString();

                    var ServiceCount = TaxiDbContext.Instance.Services.Count(s=>!s.IsDeleted && s.CustomerId == BizObject.Id);
                    lblTotalServices.Text = ServiceCount.ToString();
                }
            }
            get
            {
                return bizObject;
            }
        }

        void DeleteBizObject()
        {
            Models.Customer CustomerToRemove = TaxiDbContext.Instance.Users.Find(int.Parse(gridCustomers.CurrentRow.Cells["Id"].Value.ToString())) as Models.Customer;
            DialogResult dr = MessageBoxRTL.Ask("آیا از حذف مشتری اطمینان دارید؟", string.Empty);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //TaxiDbContext.Instance.Users.Remove(CustomerToRemove);
                    CustomerToRemove.IsDeleted = true;
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info(".مشتری با موفقیت حذف شد", string.Empty);
                    UpdateGrid();
                    BizObject = null;
                }
                catch
                {
                    MessageBoxRTL.Error("حذف مشتری با خطا روبرو شد", string.Empty);
                }
            }
        }
        public frmCustomers()
        {

            InitializeComponent();

            if (TaxiDbContext.Instance.Users.OfType<Models.Customer>().Any())
            {
                UpdateGrid();

            }

            BizObject = new Models.Customer();

            gridCustomers.CellClick += gridCustomers_CellClick;
        }
        void UpdateGrid()
        {
            gridCustomers.DataSource = TaxiDbContext.Instance.Users.OfType<Models.Customer>()
                .Where(c => !c.IsDeleted).ToList();

            gridCustomers.Columns.Where(c => c.Name == "Services").Single().IsVisible = false;
            gridCustomers.Columns.Where(c => c.Name == "Role").Single().IsVisible = false;
            gridCustomers.Columns.Where(c => c.Name == "Id").Single().IsVisible = false;
            gridCustomers.Columns.Where(c => c.Name == "IsDeleted").Single().IsVisible = false;
            gridCustomers.Columns.Where(c => c.Name == "Address").Single().IsVisible = false;
            gridCustomers.Columns.Where(c => c.Name == "DateJoined").Single().IsVisible = false;

            gridCustomers.BestFit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (BizObject != null && Validation.Validate(BizObject))
            {
                try
                {
                    if (BizObject.Id != 0)
                    {
                        Models.Customer Customer = (Models.Customer)TaxiDbContext.Instance.Users.Find(BizObject.Id);
                        Customer.FullName = BizObject.FullName;
                        Customer.Mobile = BizObject.Mobile;
                        Customer.Address = BizObject.Address;
                        TaxiDbContext.Instance.SaveChanges();
                        BizObject = null;
                        MessageBoxRTL.Info(".مشتری با موفقیت ویرایش شد", string.Empty);
                        UpdateGrid();
                    }
                    else if (BizObject.Id == 0)
                    {
                        BizObject.Role = Roles.Customer;
                        BizObject.DateJoined = DateTime.Today;
                        TaxiDbContext.Instance.Users.Add(BizObject);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".مشتری با موفقیت افزوده شد", string.Empty);
                        UpdateGrid();
                    }
                    BizObject = null;
                }
                catch
                {
                    MessageBoxRTL.Error("ذخیره سازی مشتری با خطا روبرو شد.", string.Empty);
                }
            }
        }

        private void gridCustomers_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (gridCustomers.SelectedCells.Count > 0)
            {
                switch (gridCustomers.SelectedCells[0].ColumnInfo.Name)
                {
                    case "GridEditBtn":
                        EditBizObject();
                        break;
                    case "GridDeleteBtn":
                        DeleteBizObject();
                        break;
                    default:
                        break;
                }
            }
        }

        private void EditBizObject()
        {
            BizObject = null;
            int id;
            int.TryParse(gridCustomers.SelectedCells.First().RowInfo.Cells["Id"].Value.ToString(), out id);
            UpdateGrid();
            Models.Customer CustomerToEdit = TaxiDbContext.Instance.Users.OfType<Models.Customer>().Include(u => u.Services).SingleOrDefault(c => c.Id == (int)id && c.Role == Roles.Customer);
            if (CustomerToEdit != null)
            {
                BizObject = (Models.Customer)CustomerToEdit.Clone();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BizObject = null;
        }



        protected override void btnDashboard_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDashboard();
            base.btnDashboard_Click(sender, e);
        }

        protected override void btnDrivers_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDrivers();

            base.btnDrivers_Click(sender, e);
        }

        protected override void btnPaths_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmPaths();

            base.btnPaths_Click(sender, e);
        }

        protected override void btnServices_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmServices();

            base.btnServices_Click(sender, e);
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(CurrentActiveService >= 0 && CurrentActiveService < ActiveServices.Count - 1)
            {
                CurrentActiveService++;

                Service service = ActiveServices[CurrentActiveService];

                if (service!=null)
                {
                    lblLastCost.Text = (service.Transaction.Amount / 1000).ToString();

                    var pathId = service.ServicePaths.First().PathId;
                    Path path = TaxiDbContext.Instance.Paths.Single(p => p.Id == pathId);
                    lblLastOrigin.DataBindings.Clear();
                    lblLastOrigin.DataBindings.Add("Text", path, nameof(Models.Path.Origin));

                    lblLastDestination.DataBindings.Clear();
                    lblLastDestination.DataBindings.Add("Text", path, nameof(Models.Path.Destination));
                }
                //else
                //{
                //    CurrentActiveService--;
                //}
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentActiveService >= 1)
            {
                CurrentActiveService--;
                Service service = ActiveServices[CurrentActiveService];

                if (service != null)
                {
                    lblLastCost.Text = (service.Transaction.Amount / 1000).ToString();

                    var pathId = service.ServicePaths.First().PathId;
                    Path path = TaxiDbContext.Instance.Paths.Single(p => p.Id == pathId);
                    lblLastOrigin.DataBindings.Clear();
                    lblLastOrigin.DataBindings.Add("Text", path, nameof(Models.Path.Origin));

                    lblLastDestination.DataBindings.Clear();
                    lblLastDestination.DataBindings.Add("Text", path, nameof(Models.Path.Destination));
                }
                //else
                //{
                //    CurrentActiveService++;
                //}
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                Searching = !Searching;
                if (Searching)
                {
                    btnSearch.BackgroundImage = Properties.Resources.cancel;

                    var result = TaxiDbContext.Instance.Users.OfType<Customer>()
                    .Where(c => !c.IsDeleted).Where(
                    c => c.FullName.Contains(txtSearch.Text)
                    || c.Mobile.Contains(txtSearch.Text)
                    || c.Address.Contains(txtSearch.Text))
                    .ToList();

                    gridCustomers.DataSource = result;
                }
                else
                {
                    btnSearch.BackgroundImage = Properties.Resources.search;
                    UpdateGrid();
                }
            }
        }
    }
}
