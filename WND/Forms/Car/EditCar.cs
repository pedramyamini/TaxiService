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

namespace WND.Car
{
    public partial class EditCar : Form
    {
        List<TextBox> textBoxes = new List<TextBox>();
        IQueryable<Models.User> Drivers;
        private TaxiDbContext taxiContext = new TaxiDbContext();
        public EditCar()
        {
            InitializeComponent();
        }

        public void LicensePlateRemoveHint()
        {
            foreach (var txt in textBoxes)
            {
                txt.BackColor = Color.White;
                txt.Text = string.Empty;
            }
        }

        public void LicensePlateAddHint()
        {
            txtLicencePlate1.Text = "۱۲";
            txtLicencePlate2.Text = "ت";
            txtLicencePlate3.Text = "۳۴۵";
            txtLicencePlate4.Text = "۱۱";
            foreach (var txt in textBoxes)
            {
                txt.BackColor = Color.WhiteSmoke;
            }
        }

        private void checkboxShowLicenseExample_CheckedChanged(object sender, EventArgs e)
        {
            textBoxes.Add(txtLicencePlate1);
            textBoxes.Add(txtLicencePlate2);
            textBoxes.Add(txtLicencePlate3);
            textBoxes.Add(txtLicencePlate4);
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
            Drivers = taxiContext.Users.Where(u => u.Role == Models.Roles.Driver).Select(u => u);
            comboboxDrivers.Items.AddRange(Drivers.Select(d=>d.FullName).ToArray());
            comboboxDrivers.SelectedItem = Drivers.FirstOrDefault().FullName;
        }
        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }
    }
}
