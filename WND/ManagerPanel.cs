using BaseFormLibrary;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using WND.Car;
using WND.Data;
using WND.DI.Ninject;
using WND.Driver;
using WND.Forms.Path;
using WND.Migrations;
using WND.Path;
using WND.Secretary;
using WND.Utility;
using MessageBoxRTL = WND.Utility.MessageBoxRTL;

namespace WND
{
    public partial class ManagerPanel : BaseForm
    {
        public ManagerPanel()
        {
           // InitializeComponent();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Service' table. You can move, or remove it, as needed.
            //this.serviceTableAdapter.Fill(this.taxiDataSet.Service);

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBoxRTL.Ask("آیا از خروج از حساب کاربری اطمینان دارید؟", "هشدار") == DialogResult.Yes)
            {
                Session.CurrentUser = null;
                this.Close();
            }
        }

        private void ManagerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void pictureboxAddPath_Click(object sender, EventArgs e)
        {
            new WND.Path.AddPath();
        }

        private void pictureboxAddDriver_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new AddDriver();
        }

        private void pictureboxEditCar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new EditCar().Show();
        }

        private void pictureboxAddSecretary_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new AddSecretary().Show();
        }

        protected override void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
