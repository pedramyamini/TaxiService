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
using WND.Forms.Driver;
using WND.Forms;
using WND.Forms.Services;

namespace WND
{
    public partial class frmCustomers : BaseForm
    {
        public frmCustomers()
        {
            InitializeComponent();
        }


        protected override void btnDashboard_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new Dashboard();
            base.btnDashboard_Click(sender, e);
        }

        protected override void btnDrivers_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new Drivers();

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
            new Services();

            base.btnServices_Click(sender, e);
        }

        
        private void btnDriversThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new Drivers();
        }

        private void btnServicesThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new Services();
        }

        private void btnPathsThumbnail_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmPaths();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
