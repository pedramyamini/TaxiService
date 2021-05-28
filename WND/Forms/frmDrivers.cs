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
using AutoMapper;

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

                //txtSharePercent.DataBindings.Clear();
                //txtSharePercent.DataBindings.Add("Text", BizObject, nameof(Models.Driver.SharePercent));


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
                : CarsList.Cars.Single(c => c.Model == "سایر").Colors.Single(u => u.Title == "سایر");
            string CarUrl;
            if (CarColor != null)
            {
                CarUrl = CarColor.Url.Replace(".png", string.Empty);
            }
            else
            {
                CarUrl = CarsList.Cars.Single(c => c.Model == "سایر").Colors.Single(u => u.Title == "سایر").Url
                    .Replace(".png", string.Empty);
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
                    //TaxiDbContext.Instance.Users.Remove(DriverToRemove);
                    DriverToRemove.IsDeleted = true;
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info(".راننده با موفقیت حذف شد", string.Empty);
                    UpdateGrid();
                    BizObject = null;
                }
                catch
                {
                    MessageBoxRTL.Error("حذف راننده با خطا روبرو شد", string.Empty);
                }
            }
        }

        void EditBizObject()
        {
            BizObject = null;
            int id;
            int.TryParse(gridDrivers.SelectedCells.First().RowInfo.Cells["Id"].Value.ToString(), out id);
            UpdateGrid();
            Models.Driver DriverToEdit = TaxiDbContext.Instance.Users.OfType<Models.Driver>().Include(u => u.Car).SingleOrDefault(c => c.Id == (int)id && c.Role == Roles.Driver);
            if (DriverToEdit != null)
            {
                //BizObject = (Models.Driver)DriverToEdit.Clone();
                BizObject = (Models.Driver)DriverToEdit.Clone();
                txtSharePercent.Text = BizObject.SharePercent.ToString();
            }
        }
        void UpdateGrid()
        {
            gridDrivers.DataSource = TaxiDbContext.Instance.Users.OfType<Models.Driver>()
                .Where(d=>!d.IsDeleted).Include(c => c.Car).ToList();

            gridDrivers.Columns.Where(c => c.Name == "Services").Single().IsVisible = false;
            gridDrivers.Columns.Where(c => c.Name == "Role").Single().IsVisible = false;
            gridDrivers.Columns.Where(c => c.Name == "Id").Single().IsVisible = false;
            gridDrivers.Columns.Where(c => c.Name == "Car").Single().IsVisible = false;
            gridDrivers.Columns.Where(c => c.Name == "IsDeleted").Single().IsVisible = false;

            gridDrivers.BestFit();



        }

        void UpdateDriver()
        {
            Models.Driver Driver = (Models.Driver)TaxiDbContext.Instance.Users.Single(d => d.Id == BizObject.Id);
            //Driver = BizObject;
            Driver.FullName = BizObject.FullName;
            Driver.Mobile = BizObject.Mobile;
            Driver.SharePercent = BizObject.SharePercent;
            Driver.Car.Color = BizObject.Car.Color;
            Driver.Car.Model = BizObject.Car.Model;
            Driver.Car.LicensePlate1 = BizObject.Car.LicensePlate1;
            Driver.Car.LicensePlate2 = BizObject.Car.LicensePlate2;
            Driver.Car.LicensePlate3 = BizObject.Car.LicensePlate3;
            Driver.Car.LicensePlate4 = BizObject.Car.LicensePlate4;
            BizObject.IsDeleted = false;
            TaxiDbContext.Instance.SaveChanges();
            BizObject = null;
            MessageBoxRTL.Info(".راننده با موفقیت ویرایش شد", string.Empty);
            UpdateGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int SharePercent = 0;
            int.TryParse(txtSharePercent.Text.PersianToEnglish(), out SharePercent);
            if (BizObject != null && !BizObject.IsDeleted) { BizObject.SharePercent = SharePercent; }
            if (BizObject != null && Validation.Validate(BizObject))
            {

                if (!LicensePlateCalculation.IsCompelete(BizObject.Car))
                {
                    return;
                }

                try
                {
                    if (BizObject.Id != 0)
                    {
                        UpdateDriver();
                    }
                    else if (BizObject.Id == 0)
                    {
                        //if(TaxiDbContext.Instance.Users.OfType<Models.Driver>().Any(u => u.Mobile == BizObject.Mobile))
                        //avoid repeating Driver Mobile
                        if (TaxiDbContext.Instance.Users.Any(u => u.Mobile == BizObject.Mobile
                        && u.FullName != BizObject.FullName))
                        {
                            MessageBoxRTL.Error("شماره همراه قبلا ثبت شده است. لطفا شماره دیگری وارد کنید", string.Empty);
                            return;
                        }

                        if (TaxiDbContext.Instance.Users.Any(u => u.Mobile == BizObject.Mobile
                        && u.FullName == BizObject.FullName))
                        {
                            DialogResult dr=MessageBoxRTL.Ask("این راننده قبلا ثبت شده است. آیا مایل به ویرایش آن هستید؟", string.Empty);
                            if(dr==DialogResult.OK)
                            {
                                Models.Driver CheckExistingDriver = TaxiDbContext.Instance.Users
                                    .OfType<Models.Driver>().Single(u => u.Mobile == BizObject.Mobile
                        && u.FullName == BizObject.FullName);
                                BizObject = null;
                                BizObject = CheckExistingDriver;
                                BizObject.SharePercent = SharePercent;
                                UpdateDriver();
                                return;
                            }
                            return;
                        }
                        BizObject.SharePercent = SharePercent;
                        BizObject.Role = Roles.Driver;
                        TaxiDbContext.Instance.Users.Add(BizObject);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info(".راننده با موفقیت افزوده شد", string.Empty);
                        UpdateGrid();
                        BizObject = null;
                    }
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
