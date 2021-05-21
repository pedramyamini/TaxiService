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

                if (BizObject.Id != 0 && BizObject.Role == Roles.Customer && BizObject.Services.Count > 0)
                {
                    lblLastCost.DataBindings.Clear();
                    lblLastCost.DataBindings.Add("Text", BizObject.Services.Last().Transaction, nameof(Transaction.Amount));

                    lblLastOrigin.DataBindings.Clear();
                    lblLastOrigin.DataBindings.Add("Text", BizObject.Services.Last().ServicePaths.First().Path, nameof(Models.Path.Origin));

                    lblLastDestination.DataBindings.Clear();
                    lblLastDestination.DataBindings.Add("Text", BizObject.Services.Last().ServicePaths.First().Path, nameof(Models.Path.Destination));

                    var TotalCost = BizObject.Services.Sum(s => s.Transaction.Amount);
                    lblTotalCost.Text = TotalCost.ToString();

                    lblTotalServices.DataBindings.Clear();
                    lblTotalServices.DataBindings.Add("Text", BizObject.Services, "Count");
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
                    TaxiDbContext.Instance.Users.Remove(CustomerToRemove);
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info(".مشتری با موفقیت حذف شد", string.Empty);
                    UpdateGrid();
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
            gridCustomers.DataSource = TaxiDbContext.Instance.Users.OfType<Models.Customer>().ToList();

            gridCustomers.Columns.Where(c => c.Name == "Services").Single().IsVisible = false;
            gridCustomers.Columns.Where(c => c.Name == "Role").Single().IsVisible = false;
            gridCustomers.Columns.Where(c => c.Name == "Id").Single().IsVisible = false;
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
                        var Customer = TaxiDbContext.Instance.Users.Find(BizObject.Id);
                        Customer = BizObject;
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".مشتری با موفقیت ویرایش شد", string.Empty);
                        UpdateGrid();
                    }
                    else if (BizObject.Id == 0)
                    {
                        BizObject.Role = Roles.Customer;
                        TaxiDbContext.Instance.Users.Add(BizObject);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".مشتری با موفقیت افزوده شد", string.Empty);
                        UpdateGrid();
                    }
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
                        int id;
                        int.TryParse(gridCustomers.CurrentRow.Cells["Id"].Value.ToString(), out id);
                        Models.Customer CustomerToEdit = TaxiDbContext.Instance.Users.OfType<Models.Customer>().Include(u => u.Services).SingleOrDefault(c => c.Id == (int)id && c.Role == Roles.Customer);
                        if (CustomerToEdit != null)
                        {
                            BizObject = CustomerToEdit;
                        }
                        break;
                    case "GridDeleteBtn":
                        DeleteBizObject();
                        break;
                    default:
                        break;
                }
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
    }
}
