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
using Newtonsoft.Json;
using Models.Models;

namespace WND.Forms
{
    public partial class frmDrivers : BaseForm
    {
        public Bitmap CarImage
        {
            get; set;
        }
        public frmDrivers()
        {
            btnDrivers.ChangeMenuItemImage(Properties.Resources.Drivers_out);
            InitializeComponent();

            if (TaxiDbContext.Instance.Users.OfType<Models.Driver>().Any())
            {
                UpdateGrid();
            }

            BizObject = null;

            BizObject = new Models.Driver()
            {
                Id = 0,
                FullName = string.Empty,
                Mobile = string.Empty,
                SharePercent = 0,
                DateJoined = DateTime.Today,
                Car = new Models.Car()
                {
                    Color = string.Empty,
                    LicensePlate1 = string.Empty,
                    LicensePlate2 = string.Empty,
                    LicensePlate3 = string.Empty,
                    LicensePlate4 = string.Empty,
                    Model = string.Empty
                }
            };

            gridDrivers.CellClick += gridDrivers_CellClick;

            comboboxCarModel.Items.AddRange(CarsList.Cars.Select(c => c.Model).ToArray());
            var CarsColors = CarsList.Cars.First().Colors.Select(c => c.Title).ToArray();

            comboboxCarColor.Items.AddRange(CarsColors);

            lblDateJoined.Text = DateTime.Today.ToPersianDateString();
        }


        private Models.Driver initialBizObject = new Models.Driver()
        {
            Id = 0,
            FullName = string.Empty,
            Mobile = string.Empty,
            SharePercent = 0,
            DateJoined = DateTime.Today,
            Car = new Models.Car()
            {
                Color = string.Empty,
                LicensePlate1 = string.Empty,
                LicensePlate2 = string.Empty,
                LicensePlate3 = string.Empty,
                LicensePlate4 = string.Empty,
                Model = string.Empty
            }
        };
        private Models.Driver bizObject { get; set; }

        private Models.Driver BizObject
        {
            set
            {

                if (value == null)
                {

                    bizObject = new Models.Driver()
                    {
                        Id = 0,
                        FullName = string.Empty,
                        Mobile = string.Empty,
                        SharePercent = 0,
                        Role = Roles.Driver,
                        DateJoined = DateTime.Today,
                        Car = new Models.Car()
                    };

                    this.Controls.OfType<SizableTextBox>().ToList().ForEach(t => t.ResetText());
                    this.Controls.OfType<NumericTextBox>().ToList().ForEach(t => t.ResetText());
                    this.Controls.OfType<ComboBox>().ToList().ForEach(t => t.ResetText());

                    //gridDrivers.ClearSelection();
                }
                else
                {
                    bizObject = value;
                }


                txtDriverName.DataBindings.Clear();
                txtDriverName.DataBindings.Add("Text", BizObject, nameof(Models.Driver.FullName));

                txtDriverPhone.DataBindings.Clear();
                txtDriverPhone.DataBindings.Add("Text", BizObject, nameof(Models.Driver.Mobile));

                txtSharePercent.DataBindings.Clear();
                txtSharePercent.DataBindings.Add("Text", BizObject, nameof(Models.Driver.SharePercent));


                //if (BizObject.Role == Roles.Driver && BizObject.Car != null
                //    && LicensePlateCalculation.IsCompelete(BizObject.Car))
                //{

                txtLicencePlate1.DataBindings.Clear();
                txtLicencePlate1.DataBindings.Add("Text", BizObject.Car, nameof(BizObject.Car.LicensePlate1));

                txtLicencePlate2.DataBindings.Clear();
                txtLicencePlate2.DataBindings.Add("Text", BizObject.Car, nameof(BizObject.Car.LicensePlate2));

                txtLicencePlate3.DataBindings.Clear();
                txtLicencePlate3.DataBindings.Add("Text", BizObject.Car, nameof(BizObject.Car.LicensePlate3));

                txtLicencePlate4.DataBindings.Clear();
                txtLicencePlate4.DataBindings.Add("Text", BizObject.Car, nameof(BizObject.Car.LicensePlate4));

                lblDateJoined.Text = BizObject.DateJoined.ToPersianDateString();

                comboboxCarModel.DataBindings.Clear();
                comboboxCarModel.DataBindings.Add("Text", BizObject.Car, nameof(Models.Car.Model));

                comboboxCarColor.DataBindings.Clear();
                comboboxCarColor.DataBindings.Add("Text", BizObject.Car, nameof(Models.Car.Color));

                UpdateCarPhote();
            }
            get
            {
                return bizObject;
            }
        }

        void UpdateCarPhote()
        {
            var CarModel = CarsList.Cars
                    .SingleOrDefault(m => m.Model == comboboxCarModel.Text);
            var CarColor =
                CarModel != null 
                ? CarModel.Colors.SingleOrDefault(c => c.Title == comboboxCarColor.Text)
                : CarsList.Cars.Single(c => c.Model == "سایر").Colors.Single(u=>u.Title=="سایر");
            string CarUrl;
            if (CarColor!=null)
            {
                CarUrl = CarColor.Url.Replace(".png", string.Empty);
            }
            else
            {
                CarUrl = CarsList.Cars.Single(c=>c.Model=="سایر").Colors.Single(u=>u.Title=="سایر").Url
                    .Replace(".png",string.Empty);
            }
            CarImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(CarUrl);
            CarPhoto.DataBindings.Clear();
            CarPhoto.DataBindings.Add("Image", this, nameof(CarImage), true);
            CarPhoto.Refresh();
        }

        void DeleteBizObject()
        {
            Models.Driver DriverToRemove = TaxiDbContext.Instance.Users.Find(int.Parse(gridDrivers.CurrentRow.Cells["Id"].Value.ToString())) as Models.Driver;
            DialogResult dr = MessageBoxRTL.Ask("آیا از حذف راننده اطمینان دارید؟", string.Empty);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TaxiDbContext.Instance.Users.Remove(DriverToRemove);
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info(".راننده با موفقیت حذف شد", string.Empty);
                    UpdateGrid();
                }
                catch
                {
                    MessageBoxRTL.Error("حذف راننده با خطا روبرو شد", string.Empty);
                }
            }
        }
        void UpdateGrid()
        {
            gridDrivers.DataSource = TaxiDbContext.Instance.Users.OfType<Models.Driver>().Include(c => c.Car).ToList();

            gridDrivers.Columns.Where(c => c.Name == "Services").Single().IsVisible = false;
            gridDrivers.Columns.Where(c => c.Name == "Role").Single().IsVisible = false;
            gridDrivers.Columns.Where(c => c.Name == "Id").Single().IsVisible = false;
            gridDrivers.Columns.Where(c => c.Name == "Car").Single().IsVisible = false;

            gridDrivers.BestFit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BizObject != null && Validation.Validate(BizObject))
            {


                if (!LicensePlateCalculation.IsCompelete(BizObject.Car))
                {
                    MessageBoxRTL.Error("پلاک خودرو ضروری است", string.Empty);
                    return;
                }

                try
                {
                    if (BizObject.Id != 0)
                    {
                        var Driver = TaxiDbContext.Instance.Users.Find(BizObject.Id);
                        Driver = BizObject;
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".راننده با موفقیت ویرایش شد", string.Empty);
                        UpdateGrid();
                    }
                    else if (BizObject.Id == 0)
                    {
                        if (TaxiDbContext.Instance.Users.Any(u => u.Mobile == BizObject.Mobile))
                        {
                            MessageBoxRTL.Error("شماره همراه قبلا ثبت شده است. لطفا شماره دیگری وارد کنید", string.Empty);
                            return;
                        }
                        BizObject.Role = Roles.Driver;
                        TaxiDbContext.Instance.Users.Add(BizObject);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".راننده با موفقیت افزوده شد", string.Empty);
                        UpdateGrid();
                    }
                    BizObject = null;
                }
                catch
                {
                    MessageBoxRTL.Error("ذخیره سازی راننده با خطا روبرو شد.", string.Empty);
                }
            }
        }

        private void gridDrivers_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (gridDrivers.SelectedCells.Count > 0)
            {
                switch (gridDrivers.SelectedCells[0].ColumnInfo.Name)
                {
                    case "GridEditBtn":
                        int id;
                        int.TryParse(gridDrivers.CurrentRow.Cells["Id"].Value.ToString(), out id);
                        Models.Driver DriverToEdit = TaxiDbContext.Instance.Users.OfType<Models.Driver>().Include(u => u.Car).SingleOrDefault(c => c.Id == (int)id && c.Role == Roles.Driver);
                        if (DriverToEdit != null)
                        {
                            BizObject = DriverToEdit;
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
            SwitchBetweenForms = true;
            this.Close();
            new frmDashboard();

            base.btnDashboard_Click(sender, e);
        }

        protected override void btnDrivers_Click(object sender, EventArgs e)
        {

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
            SwitchBetweenForms = true;
            this.Close();
            new frmServices();

            base.btnServices_Click(sender, e);
        }

        private void comboboxCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCarPhote();
        }

        private void comboboxCarColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCarPhote();
        }

        private void comboboxCarModel_TextChanged(object sender, EventArgs e)
        {
            UpdateCarPhote();
        }

        private void comboboxCarColor_TextChanged(object sender, EventArgs e)
        {
            UpdateCarPhote();
        }

        private void comboboxCarModel_TextUpdate(object sender, EventArgs e)
        {
            UpdateCarPhote();
        }

        private void comboboxCarColor_TextUpdate(object sender, EventArgs e)
        {
            UpdateCarPhote();
        }
    }
}
