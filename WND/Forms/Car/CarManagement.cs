using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using WND.DI.Ninject;
using WND.Models;
using WND.Utility;

namespace WND.Car
{
    public partial class EditCar : Form
    {
        Models.Driver selectedDriver;
        List<TextBox> LicensePlateTextBoxes = new List<TextBox>();
        IQueryable<Models.User> Drivers;
        private ITaxiDbContext taxiContext;
        Form sourceForm;

        void FillTextBoxes()
        {
            //Fill LincensePlate TextBoxes
            if (LicensePlateTextBoxes.Count == 0)
            {
                LicensePlateTextBoxes.Add(txtLicencePlate1);
                LicensePlateTextBoxes.Add(txtLicencePlate2);
                LicensePlateTextBoxes.Add(txtLicencePlate3);
                LicensePlateTextBoxes.Add(txtLicencePlate4);

            }
            BindCar();
        }

        public EditCar(ITaxiDbContext _taxiContext)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
        }

        public EditCar(ITaxiDbContext _taxiContext, Form _sourceForm)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
            this.sourceForm = _sourceForm;
        }

        public void LicensePlateRemoveHint()
        {
            //Hide LicensePlate Example
            foreach (var txt in LicensePlateTextBoxes)
            {
                txt.BackColor = Color.White;
                txt.Text = string.Empty;
            }
        }

        public void LicensePlateAddHint()
        {
            //Show LicensePlate Example
            txtLicencePlate1.Text = "۱۲";
            txtLicencePlate2.Text = "ت";
            txtLicencePlate3.Text = "۳۴۵";
            txtLicencePlate4.Text = "۱۱";
            foreach (var txt in LicensePlateTextBoxes)
            {
                txt.BackColor = Color.WhiteSmoke;
            }
        }

        void BindCar()
        {
            //binding car
            try
            {
                txtModel.Text = selectedDriver.Car.Model;
                txtColor.Text = selectedDriver.Car.Color;
                string[] LicensePlate = new string[4];
                for (int i = 0; i < LicensePlateTextBoxes.Count; i++)
                {
                    LicensePlateTextBoxes[i].Text = string.Empty;
                }
                if (!string.IsNullOrEmpty(selectedDriver.Car.LicensePlate))
                {
                    LicensePlate = selectedDriver.Car.LicensePlate.Split('-');

                    for (int i = 0; i < LicensePlateTextBoxes.Count; i++)
                    {
                        LicensePlateTextBoxes[i].Text = LicensePlate[i];
                    }
                }
            }
            catch
            {

            }
        }

        private void checkboxShowLicenseExample_CheckedChanged(object sender, EventArgs e)
        {
            //Show LicensePlate Example
            FillTextBoxes();
            if (checkboxShowLicenseExample.Checked)
            {
                LicensePlateAddHint();
            }
            else
            {
                LicensePlateRemoveHint();
            }
        }

        private void EditCar_Load(object sender, EventArgs e)
        {
            //check if any car exists
            if (taxiContext.Cars.Any())
            {
                Drivers = taxiContext.Users.OfType<Models.Driver>().Where(u => u.Role == Models.Roles.Driver).Select(u => u);
                comboboxDrivers.Items.AddRange(Drivers.Select(d => d.FullName).ToArray());
                comboboxDrivers.SelectedItem = Drivers.FirstOrDefault().FullName;
                selectedDriver = Drivers.OfType<Models.Driver>().FirstOrDefault();
                FillTextBoxes();
            }
            else
            {
                MessageBoxRTL.Error("خودرویی یافت نشد. لطفا ابتدا رانندگان را ثبت کنید.", string.Empty);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }


        private void comboboxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //find selected driver in combobox by its name
            selectedDriver = taxiContext.Users
                .OfType<Models.Driver>()
                .Where(d => d.FullName == comboboxDrivers.SelectedItem.ToString())
                .Select(d => d).SingleOrDefault();

            FillTextBoxes();

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask($"آیا از ویرایش خودرو مربوط به {selectedDriver.FullName} اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {
                string LicensePlate = LicensePlateCalculation.CalculateLicensePlate(LicensePlateTextBoxes);

                Models.Car car = new Models.Car()
                {
                    LicensePlate = LicensePlate,
                    Color = txtColor.Text,
                    Model = txtModel.Text
                };

                //validate car
                if (string.IsNullOrEmpty(car.LicensePlate.Replace("-", "")) || string.IsNullOrEmpty(car.Model) || string.IsNullOrEmpty(car.Color))
                {
                    MessageBoxRTL.Error("تمامی موارد فرم ضروری هستند و نمی‌توانند خالی باشند.", string.Empty);
                    return;
                }
                try
                {
                    //update car
                    taxiContext.Cars.Attach(selectedDriver.Car);

                    selectedDriver.Car = car;

                    taxiContext.SaveChanges();

                    MessageBoxRTL.Info("ویرایش خودرو با موفقیت انجام شد.", string.Empty);
                    FillTextBoxes();
                }
                catch
                {
                    MessageBoxRTL.Error("ویرایش خودرو با خطا روبرو شد.", string.Empty);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask($"آیا از حذف خودرو مربوط به {selectedDriver.FullName} اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {
                Models.Car car = new Models.Car();

                car.Model = string.Empty;
                car.Color = string.Empty;
                car.LicensePlate = string.Empty;

                try
                {
                    //delete car
                    taxiContext.Cars.Attach(selectedDriver.Car);

                    selectedDriver.Car = car;

                    taxiContext.SaveChanges();

                    MessageBoxRTL.Info("حذف خودرو با موفقیت انجام شد.", string.Empty);
                    FillTextBoxes();
                }
                catch
                {
                    MessageBoxRTL.Error("حذف خودرو با خطا روبرو شد.", string.Empty);
                }
            }
        }

        private void EditCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txtLicencePlate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //a LicensePlate only accepts one letter this event checks its correctness
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^([وهیبتعجدسصطقلمنوهیبتعجدسصطقلمن]){1}$"))
            {
                e.Handled = true;
                txtLicencePlate2.SelectAll();
            }
            else
            {
                e.Handled = false;
                txtLicencePlate2.SelectAll();
            }
        }

        private void EditCar_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
