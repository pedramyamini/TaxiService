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

namespace WND.Forms.Services
{
    public partial class Services : BaseForm
    {
        public Services()
        {
            btnServices.ChangeMenuItemImage(Properties.Resources.Service_out);
        }
        protected override void btnDashboard_Click(object sender, EventArgs e)
        {
            SwitchBetweenForms = true;
            this.Close();
            new Dashboard();

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
            

            base.btnServices_Click(sender, e);
        }
    }
}
