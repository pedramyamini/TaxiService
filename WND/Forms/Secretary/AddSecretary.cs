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
using WND.Models;
using WND.Utility;

namespace WND.Secretary
{
    public partial class AddSecretary : Form
    {
        private TaxiDbContext taxiContext=new TaxiDbContext();
        public AddSecretary()
        {
            InitializeComponent();
        }
        private void AddSecretary_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            try
            {
                taxiContext.AuthenticatedUsers.Add(new AuthenticatedUser()
                {
                    FullName = txtFullName.Text,
                    Username = txtUsername.Text,
                    Password = EasyHash.Hash(txtPassword.Text),
                    Mobile = txtMobile.Text,
                    Role = Roles.Secretary
                });
                taxiContext.SaveChanges();
                MessageBoxRTL.Info("منشی با موفقیت افزوده شد.", "");
                this.Close();
                new ManagerPanel().Show();
            }
            catch
            {
                MessageBoxRTL.Info("لطفا مجددا تلاش نمایید و از صحت ورودی‌ها اطمینان حاصل کنید", "");
            }
        }
    }
}
