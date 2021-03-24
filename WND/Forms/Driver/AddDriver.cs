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

namespace WND.Driver
{
    public partial class AddDriver : Form
    {
        private TaxiDbContext taxiContext = new TaxiDbContext();
        public AddDriver()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if(Validation.ValidateFullName(txtFullName.Text) && Validation.ValidateMobile(txtMobile.Text.PersianToEnglish()) && Validation.ValidateSharePercent(txtSharePercent.Text.PersianToEnglish()))
            {
                try
                {
                    taxiContext.Users.Add(
                    new Models.Driver()
                    {
                        FullName = txtFullName.Text,
                        Mobile = txtMobile.Text.PersianToEnglish(),
                        SharePercent = int.Parse(txtSharePercent.Text.PersianToEnglish()),
                        Role = Models.Roles.Driver,
                        Car=new Models.Car()
                        {
                            
                        }
                    });
                    taxiContext.SaveChanges();
                    MessageBoxRTL.Info("راننده با موفقیت افزوده شد.", "");
                }
                catch
                {
                    MessageBoxRTL.Error("افزودن راننده با خطا مواجه شد لطفا دوباره تلاش کنید", "");
                }
                
            }
            else
            {
                MessageBoxRTL.Info("لطفا ورودی‌ها را با دقت وارد نمایید.", "");
            }
        }
    }
}
