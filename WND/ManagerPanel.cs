using System;
using System.Windows.Forms;
using WND.Car;
using WND.Driver;
using WND.Secretary;
using WND.Utility;

namespace WND
{
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
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
                this.Close();
                Session.CurrentUser = null;
                new Login().Show();
            }
        }

        

        private void ManagerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBoxRTL.Ask("آیا از خروج کامل از برنامه اطمینان دارید؟", "هشدار") == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ManagerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void AddSecretary_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddSecretary().Show();
        }

        private void AddDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddDriver().Show();
        }

        private void EditCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditCar().Show();
        }
    }
}
