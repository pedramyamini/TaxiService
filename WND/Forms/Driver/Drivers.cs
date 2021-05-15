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
using WND.Forms.Path;
using WND.Forms.Services;

namespace WND.Forms.Driver
{
    public partial class Drivers : BaseForm
    {
        public Drivers()
        {
            btnDrivers.ChangeMenuItemImage(Properties.Resources.Drivers_out);
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
            new Services.Services();

            base.btnServices_Click(sender, e);
        }
    }
}
