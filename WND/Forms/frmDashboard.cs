using BaseFormLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;
using WND.Forms;

namespace WND
{
    public partial class frmDashboard : BaseForm
    {
        public frmDashboard()
        {
            btnDashboard.ChangeMenuItemImage(Properties.Resources.Dashboard_out);
            InitializeComponent();
        }


        protected override void btnDashboard_Click(object sender, EventArgs e)
        {
            //Nothing to do because already dashboard is open
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
            SwitchBetweenForms = true;
            this.Close();
            new frmServices();

            base.btnServices_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        
        private void btnDriversThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDrivers();
        }

        private void btnServicesThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmServices();
        }

        private void btnPathsThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmPaths();
        }

        private void btnCustomersThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmCustomers();
        }

        private void btnSecretaryThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmSecretaries();
        }
    }
}
