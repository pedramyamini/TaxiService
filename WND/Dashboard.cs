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
using WND.Forms.Path;
using WND.Forms.Services;

namespace WND
{
    public partial class Dashboard : BaseForm
    {
        public Dashboard()
        {
            btnDashboard.ChangeMenuItemImage(Properties.Resources.Dashboard_out);
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
            new Drivers();

            base.btnDrivers_Click(sender, e);
        }

        protected override void btnPaths_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new Paths();

            base.btnPaths_Click(sender, e);
        }

        protected override void btnServices_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new Services();

            base.btnServices_Click(sender, e);
        }
    }
}
