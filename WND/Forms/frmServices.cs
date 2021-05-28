using BaseFormLibrary;
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
    public partial class frmServices : BaseForm
    {
        private TaxiDbContext db = TaxiDbContext.Instance;
        Models.Service ServiceToEdit;
        public frmServices()
        {
            btnServices.ChangeMenuItemImage(Properties.Resources.Service_out);
            InitializeComponent();

            if (db.Services.Any())
            {
                UpdateGrid();
            }

            BizObject = null;

            gridServices.CellClick += gridServices_CellClick;

            txtCustomerName.Multiline = false;
            var CustomersNames = db.Users.OfType<Models.Customer>().Select(c => c.FullName).ToArray();
            AutoCompleteStringCollection CustomerNameSource = new AutoCompleteStringCollection();
            CustomerNameSource.AddRange(CustomersNames);
            txtCustomerName.AutoCompleteCustomSource = CustomerNameSource;

            comboboxDrivers.Items.AddRange(db.Users.OfType<Models.Driver>().Select(d => d.FullName).ToArray());
            comboboxPaths.Items.AddRange(db.Paths.Select(p => p.OriginDestination).ToArray());
            lblDate.Text = DateTime.Today.ToPersianDateString();
        }


        private Models.Service bizObject { get; set; }

        private Models.Service BizObject
        {
            set
            {

                if (value == null)
                {

                    bizObject = new Models.Service()
                    {
                        Id = 0,
                        Customer = new Models.Customer()
                        {
                            FullName = string.Empty,
                            Mobile = string.Empty,
                            Address = string.Empty,
                            Role = Models.Roles.Customer
                        },
                        Driver = new Models.Driver()
                        {
                            FullName = string.Empty,
                            Mobile = string.Empty,
                            SharePercent = 0,
                            DateJoined = DateTime.Today,
                            Role = Models.Roles.Driver,
                            Car = new Models.Car()
                            {
                                Model = string.Empty,
                                Color = string.Empty,
                                LicensePlate1 = string.Empty,
                                LicensePlate2 = string.Empty,
                                LicensePlate3 = string.Empty,
                                LicensePlate4 = string.Empty
                            }
                        },
                        Delay = 0,
                        DateTime = DateTime.Today,
                        Transaction = new Models.Transaction()
                        {
                            Amount = 0,
                            IsPaid = false,
                        },
                        IsActive = true,
                        OriginInDetail = string.Empty,
                        DestinationInDetail = string.Empty,
                        IsDeleted = false,
                        ServicePaths = new List<Models.ServicePath>()
                        {
                            new Models.ServicePath()
                            {
                                Path=new Models.Path()
                                {
                                    Origin=string.Empty,
                                    Destination=string.Empty,
                                    OriginDestination= string.Empty,
                                }
                            }
                        }
                    };

                    this.Controls.OfType<SizableTextBox>().ToList().ForEach(t => t.ResetText());
                    this.Controls.OfType<NumericTextBox>().ToList().ForEach(t => t.ResetText());
                    this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.ResetText());

                    //gridDrivers.ClearSelection();
                }
                else
                {
                    bizObject = value;

                    //txtCustomerName.DataBindings.Clear();
                    //txtCustomerName.DataBindings.Add("Text", BizObject.Customer, nameof(Models.Customer.FullName));

                    //txtCustomerPhone.DataBindings.Clear();
                    //txtCustomerPhone.DataBindings.Add("Text", BizObject.Customer, nameof(Models.Customer.Mobile));

                    //txtDelay.DataBindings.Clear();
                    //txtDelay.DataBindings.Add("Text", BizObject, nameof(Models.Service.Delay));

                    //if (BizObject.Driver.Car != null)
                    //{
                    //    lblLicencePlate1.DataBindings.Clear();
                    //    lblLicencePlate1.DataBindings.Add("Text", BizObject.Driver.Car, nameof(Models.Car.LicensePlate1));

                    //    lblLicencePlate2.DataBindings.Clear();
                    //    lblLicencePlate2.DataBindings.Add("Text", BizObject.Driver.Car, nameof(Models.Car.LicensePlate2));

                    //    lblLicencePlate3.DataBindings.Clear();
                    //    lblLicencePlate3.DataBindings.Add("Text", BizObject.Driver.Car, nameof(Models.Car.LicensePlate3));

                    //    lblLicencePlate4.DataBindings.Clear();
                    //    lblLicencePlate4.DataBindings.Add("Text", BizObject.Driver.Car, nameof(Models.Car.LicensePlate4));
                    //}

                    lblDate.Text = BizObject.DateTime.ToPersianDateString();

                    //comboboxDrivers.DataBindings.Clear();
                    //comboboxDrivers.DataBindings.Add("Text", BizObject.Driver, nameof(Models.Driver.FullName));

                    //if (BizObject.ServicePaths != null)
                    //{
                    //    comboboxPaths.DataBindings.Clear();
                    //    comboboxPaths.DataBindings.Add("Text", BizObject.ServicePaths.First().Path, nameof(Models.Path.OriginDestination));
                    //}

                    //txtOriginInDetail.DataBindings.Clear();
                    //txtOriginInDetail.DataBindings.Add("Text", BizObject, nameof(Models.Service.OriginInDetail));

                    //txtDestinationInDetail.DataBindings.Clear();
                    //txtDestinationInDetail.DataBindings.Add("Text", BizObject, nameof(Models.Service.DestinationInDetail));

                    if (BizObject.ServicePaths.First() == null)
                    {
                        lblCost.Text = "0";
                    }


                    //checkboxIsPaid.DataBindings.Clear();
                    //checkboxIsPaid.DataBindings.Add("Checked", BizObject.Transaction, nameof(Models.Transaction.IsPaid));

                    //if (BizObject.Driver.Car != null && string.IsNullOrEmpty(BizObject.Driver.Car.Model))
                    //{
                    //    lblCar.Text = BizObject.Driver.Car.Model + BizObject.Driver.Car.Color;
                    //}
                    //else
                    //{
                    //    lblCar.Text = string.Empty;
                    //}
                }




            }
            get
            {
                return bizObject;
            }
        }
        void DeleteBizObject()
        {
            Models.Service ServiceToRemove = db.Services.Find(int.Parse(gridServices.CurrentRow.Cells["Id"].Value.ToString()));
            DialogResult dr = MessageBoxRTL.Ask("آیا از حذف سرویس اطمینان دارید؟", string.Empty);
            if (dr == DialogResult.OK)
            {
                try
                {
                    ServiceToRemove.IsDeleted = true;
                    db.SaveChanges();
                    MessageBoxRTL.Info(".سرویس با موفقیت حذف شد", string.Empty);
                    ClearForm();
                    UpdateGrid();
                    BizObject = null;
                }
                catch
                {
                    MessageBoxRTL.Error("حذف سرویس با خطا روبرو شد", string.Empty);
                }
            }
        }

        void EditBizObject()
        {
            //BizObject = null;
            int id;
            int.TryParse(gridServices.SelectedCells.First().RowInfo.Cells["Id"].Value.ToString(), out id);
            UpdateGrid();
            ServiceToEdit = db.Services.SingleOrDefault(s => s.Id == (int)id);
            if (ServiceToEdit != null)
            {
                txtCustomerName.Text = ServiceToEdit.Customer.FullName;
                txtCustomerPhone.Text = ServiceToEdit.Customer.Mobile;
                comboboxPaths.Text = ServiceToEdit.ServicePaths.First().Path.OriginDestination;
                lblCost.Text = ServiceToEdit.ServicePaths.First().Path.Cost.ToString();
                comboboxDrivers.Text = ServiceToEdit.Driver.FullName;
                lblCar.Text = ServiceToEdit.Driver.Car.Model + " " + ServiceToEdit.Driver.Car.Color;
                lblLicencePlate1.Text = ServiceToEdit.Driver.Car.LicensePlate1;
                lblLicencePlate2.Text = ServiceToEdit.Driver.Car.LicensePlate2;
                lblLicencePlate3.Text = ServiceToEdit.Driver.Car.LicensePlate3;
                lblLicencePlate4.Text = ServiceToEdit.Driver.Car.LicensePlate4;
                lblDate.Text = ServiceToEdit.DateTime.ToPersianDateString();
                txtOriginInDetail.Text = ServiceToEdit.OriginInDetail;
                txtDestinationInDetail.Text = ServiceToEdit.DestinationInDetail;
                txtDelay.Text = ServiceToEdit.Delay.ToString();
                checkboxIsPaid.Checked = ServiceToEdit.Transaction.IsPaid;
            }
        }
        void UpdateGrid()
        {
            var Services = new List<Models.Service>();
            using (TaxiDbContext taxiDb = new TaxiDbContext())
            {
                Services = taxiDb.Services
               .Where(s => !s.IsDeleted).ToList();

                var VMServices = new List<Models.ViewModels.VMService>();

                Services.ForEach(
                    s => VMServices.Add(
                        new Models.ViewModels.VMService()
                        {
                            Id = s.Id,
                            CustomerFullName = s.Customer.FullName,
                            CustomerMobile = s.Customer.Mobile,
                            DriverFullName = s.Driver.FullName,
                            DriverMobile = s.Driver.Mobile,
                            Cost = s.Transaction.Amount,
                            DateTime = s.DateTime,
                            IsPaid = s.Transaction.IsPaid,
                            Path = s.ServicePaths.First().Path.OriginDestination
                        }
                        ));

                gridServices.DataSource = VMServices.OrderByDescending(s => s.DateTime);
            }



            gridServices.Columns.Where(c => c.Name == "Id").Single().IsVisible = false;

            gridServices.BestFit();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BizObject != null)
            {
                try
                {
                    if (ServiceToEdit != null && ServiceToEdit.Id != 0)
                    {
                        //BizObject = (Models.Driver)DriverToEdit.Clone();
                        //BizObject = (Models.Service)ServiceToEdit.Clone();

                        //Models.Service Service = (Models.Service)db.Services
                        //    .Single(d => d.Id == BizObject.Id);

                        using (TaxiDbContext taxiDb = new TaxiDbContext())
                        {
                            Models.Service service = taxiDb.Services.Find(ServiceToEdit.Id);
                            service.DriverId = taxiDb.Users.OfType<Models.Driver>()
                            .SingleOrDefault(d => d.FullName == comboboxDrivers.Text).Id;

                            var NewPath = taxiDb.Paths.SingleOrDefault(p => p.OriginDestination == comboboxPaths.Text);
                            service.ServicePaths.First().PathId = NewPath.Id;

                            service.Transaction.Amount = NewPath.Cost;
                            service.Transaction.IsPaid = checkboxIsPaid.Checked;

                            if (taxiDb.Users.OfType<Models.Customer>().Any(c => c.FullName == txtCustomerName.Text))
                            {
                                service.CustomerId =
                                    taxiDb.Users.OfType<Models.Customer>().Single(c => c.FullName == txtCustomerName.Text).Id;
                            }
                            else
                            {
                                service.Customer = new Models.Customer()
                                {
                                    Role = Models.Roles.Customer,
                                    FullName = txtCustomerName.Text,
                                    Mobile = txtCustomerPhone.Text,
                                    Address = "ثبت نشده"
                                };
                            }


                            taxiDb.SaveChanges();
                        }

                        TaxiDbContext.Instance.RefreshDbContext();

                        BizObject = null;
                        MessageBoxRTL.Info(".سرویس با موفقیت ویرایش شد", string.Empty);
                        ClearForm();
                        UpdateGrid();
                    }
                    else if (BizObject.Id == 0)
                    {
                        using (TaxiDbContext taxiDb = new TaxiDbContext())
                        {
                            if (string.IsNullOrEmpty(txtCustomerName.Text))
                            {
                                MessageBoxRTL.Error("نام مشتری ضروری است.", string.Empty);
                                txtCustomerName.Focus();
                                return;
                            }
                            if (string.IsNullOrEmpty(txtCustomerPhone.Text) &&
                                !txtCustomerPhone.Text.StartsWith("09") &&
                                txtCustomerPhone.Text.Length != 11)
                            {
                                MessageBoxRTL.Error("شماره همراه مشتری ضروری است. و با 09 آغاز می‌شود", string.Empty);
                                txtCustomerPhone.Focus();
                                return;
                            }
                            if (string.IsNullOrEmpty(comboboxDrivers.Text))
                            {
                                MessageBoxRTL.Error("نام راننده ضروری است.", string.Empty);
                                comboboxDrivers.Focus();
                                return;
                            }
                            if (string.IsNullOrEmpty(comboboxPaths.Text))
                            {
                                MessageBoxRTL.Error("مسیر ضروری است.", string.Empty);
                                comboboxPaths.Focus();
                                return;
                            }

                            //avoid adding a new customer with different name but exisiting phone -- TWO Customer With Same Phone
                            if (taxiDb.Users.OfType<Models.Customer>().Any(c => c.Mobile == txtCustomerPhone.Text && c.FullName != txtCustomerName.Text))
                            {
                                MessageBoxRTL.Error("شماره همراه مشتری قبلا ثبت شده است. لطفا شماره دیگری وارد نمایید", string.Empty);
                                txtCustomerPhone.Focus();
                                return;
                            }

                            BizObject.Customer = taxiDb.Users.OfType<Models.Customer>().SingleOrDefault(c => c.Mobile == txtCustomerPhone.Text);

                            if (BizObject.Customer == null)
                            {
                                BizObject.Customer = new Models.Customer()
                                {
                                    FullName = txtCustomerName.Text,
                                    Mobile = txtCustomerPhone.Text.PersianToEnglish(),
                                    Address = "ثبت نشده",
                                    Role = Models.Roles.Customer
                                };
                            }

                            //driver
                            if (!comboboxDrivers.Items.Contains(comboboxDrivers.Text))
                            {
                                MessageBoxRTL.Error("راننده‌ای با این مشخصات وجود ندارد", string.Empty);
                                comboboxDrivers.Focus();
                                return;
                            }

                            BizObject.Driver = taxiDb.Users.OfType<Models.Driver>()
                                .SingleOrDefault(d => d.FullName == comboboxDrivers.Text);

                            //path
                            if (!comboboxPaths.Items.Contains(comboboxPaths.Text))
                            {
                                MessageBoxRTL.Error("مسیری با این مشخصات وجود ندارد", string.Empty);
                                comboboxPaths.Focus();
                                return;
                            }

                            BizObject.ServicePaths = new List<Models.ServicePath>();
                            var NewPath = taxiDb.Paths
                                .SingleOrDefault(p => p.OriginDestination == comboboxPaths.Text);
                            BizObject.ServicePaths.Add(new Models.ServicePath()
                            {
                                Path = NewPath
                            });

                            BizObject.Transaction.IsPaid = checkboxIsPaid.Checked;
                            BizObject.Transaction.Amount = NewPath.Cost;

                            BizObject.OriginInDetail = txtOriginInDetail.Text;
                            BizObject.DestinationInDetail = txtDestinationInDetail.Text;

                            BizObject.DateTime = DateTime.Now;

                            int Delay = 0;
                            int.TryParse(txtDelay.Text, out Delay);
                            BizObject.Delay = Delay;

                            BizObject.IsActive = true;
                            BizObject.IsDeleted = false;


                            taxiDb.Services.Add(BizObject);
                            taxiDb.SaveChanges();
                        }
                        db = new TaxiDbContext();
                        BizObject = null;

                        MessageBoxRTL.Info(".سرویس با موفقیت افزوده شد", string.Empty);
                        ClearForm();
                        UpdateGrid();
                    }
                }
                catch
                {
                    MessageBoxRTL.Error("ذخیره سازی سرویس با خطا روبرو شد.", string.Empty);
                }
            }
        }

        private void gridServices_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (gridServices.SelectedCells.Count > 0)
            {
                switch (gridServices.SelectedCells[0].ColumnInfo.Name)
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




        protected override void btnDashboard_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new frmDashboard();

            base.btnDashboard_Click(sender, e);
        }

        protected override void btnDrivers_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new frmDrivers();

            base.btnDrivers_Click(sender, e);
        }

        protected override void btnPaths_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new frmPaths();

            base.btnPaths_Click(sender, e);
        }

        protected override void btnServices_Click(object sender, EventArgs e)
        {
            base.btnServices_Click(sender, e);
        }


        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            if (!db.Users.OfType<Models.Customer>().Any(c => c.FullName == txtCustomerName.Text))
            {
                txtCustomerPhone.ReadOnly = false;
                txtCustomerPhone.Text = "09";
            }
            else
            {
                txtCustomerPhone.ReadOnly = false;
                txtCustomerPhone.Text = db.Users.OfType<Models.Customer>().First(c => c.FullName == txtCustomerName.Text).Mobile;
                txtCustomerPhone.ReadOnly = true;
            }
        }

        private void comboboxPaths_TextChanged(object sender, EventArgs e)
        {
            if (comboboxPaths.Text.Length > 3)
            {
                var Path = db.Paths.SingleOrDefault(p => p.OriginDestination == comboboxPaths.Text);
                if (Path != null)
                {
                    if (BizObject!=null && BizObject.ServicePaths != null)
                    {
                        BizObject.ServicePaths.First().Path.Id = Path.Id;
                    }
                    else if(BizObject!=null)
                    {
                        BizObject.ServicePaths = new List<Models.ServicePath>()
                        {
                           new Models.ServicePath()
                           {
                               PathId = Path.Id
                           }  
                        };
                    }
                    lblCost.Text = Path.Cost.ToString();
                }
            }
        }


        private void comboboxDrivers_TextChanged(object sender, EventArgs e)
        {
            if (comboboxDrivers.Text.Length > 3)
            {
                var Driver = db.Users.OfType<Models.Driver>()
                    .SingleOrDefault(d => d.FullName == comboboxDrivers.Text);
                if (Driver != null)
                {
                    BizObject.Driver = Driver.CopyObject<Models.Driver>();
                    lblCar.Text = Driver.Car.Model + " " + Driver.Car.Color;

                    lblLicencePlate1.Text = Driver.Car.LicensePlate1;
                    lblLicencePlate2.Text = Driver.Car.LicensePlate2;
                    lblLicencePlate3.Text = Driver.Car.LicensePlate3;
                    lblLicencePlate4.Text = Driver.Car.LicensePlate4;
                }
                else
                {
                    lblCar.Text = string.Empty;
                    lblLicencePlate1.Text = string.Empty;
                    lblLicencePlate2.Text = string.Empty;
                    lblLicencePlate3.Text = string.Empty;
                    lblLicencePlate4.Text = string.Empty;
                }
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ClearForm();
        }

        void ClearForm()
        {
            BizObject = null;
            ServiceToEdit = null;

            this.Controls.OfType<NumericTextBox>().ToList().ForEach(t => t.ResetText());
            this.Controls.OfType<SizableTextBox>().ToList().ForEach(t => t.ResetText());
            this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.ResetText());
            this.Controls.OfType<CheckBox>().ToList().ForEach(t => t.Checked = false);

            txtCustomerPhone.Text = "09";
            lblDate.Text = DateTime.Today.ToPersianDateString();
            lblCar.Text = string.Empty;
            lblCost.Text = string.Empty;
            lblLicencePlate1.Text = string.Empty;
            lblLicencePlate2.Text = string.Empty;
            lblLicencePlate3.Text = string.Empty;
            lblLicencePlate4.Text = string.Empty;
        }
    }
}
