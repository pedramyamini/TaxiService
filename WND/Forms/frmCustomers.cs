﻿using BaseFormLibrary;
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

namespace WND.Forms
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
            new frmDashboard();
            base.btnDashboard_Click(sender, e);
        }

        protected override void btnDrivers_Click(object sender, EventArgs e)
        {
            this.CloseWithoutAsk();
            new frmDrivers();

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
            new frmServices();

            base.btnServices_Click(sender, e);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
