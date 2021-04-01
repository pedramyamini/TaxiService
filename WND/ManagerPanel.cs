using System;
using System.Data.Entity;
using System.Windows.Forms;
using WND.Car;
using WND.Data;
using WND.DI.Ninject;
using WND.Driver;
using WND.Migrations;
using WND.Path;
using WND.Secretary;
using WND.Utility;

namespace WND
{
    public partial class ManagerPanel : Form
    {
        private ITaxiDbContext taxiContext;
        Form sourceForm;
        public ManagerPanel(ITaxiDbContext _taxiContext, Form _sourceForm)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
            sourceForm = _sourceForm;
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



        private void ManagerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {
                if (Utility.Session.RecentlyRegisteredAdmin)
                {
                    new Login(taxiContext).Show();
                    Utility.Session.RecentlyRegisteredAdmin = false;
                }
                else
                {
                    sourceForm.Enabled = true;
                    sourceForm.Show();
                    sourceForm.Focus();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ManagerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AddSecretary_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new AddSecretary(taxiContext, this).Show();
        }

        private void AddDriver_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new AddDriver(taxiContext, this).Show();
        }

        private void EditCar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new EditCar(taxiContext, this).Show();
        }

        private void AddPath_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new WND.Path.AddPath(taxiContext, this).Show();
        }

        private void AddSpot_Click(object sender, EventArgs e)
        {

        }
    }
}
