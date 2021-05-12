using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
                Models.AuthenticatedUser secretary = new AuthenticatedUser()
                {
                    FullName = txtFullName.Text,
                    Username = txtUsername.Text,
                    Password = EasyHash.Hash(txtPassword.Text),
                    Mobile = txtMobile.Text.PersianToEnglish(),
                    Role = Roles.Secretary,
                    SecurityQuestion = string.Empty,
                    SecurityAnswer = string.Empty
                };
                if (Validation.Validate(secretary))
                {
                    if (TaxiDbContext.Instance.Users.Any(s => s.Mobile == secretary.Mobile))
                    {
                        MessageBoxRTL.Error("شماره همراه نمی‌تواند تکراری باشد", "");
                        return;
                    }
                    if(TaxiDbContext.Instance.Users.OfType<Models.AuthenticatedUser>().Any(s=>s.Username==secretary.Username))
                    {
                        MessageBoxRTL.Error("نام کاربری نمی‌تواند تکراری باشد", "");
                        return;
                    }
                    TaxiDbContext.Instance.AuthenticatedUsers.Add(secretary);
                    TaxiDbContext.Instance.SaveChanges();
                    MessageBoxRTL.Info("منشی با موفقیت افزوده شد.", "");
                }
            }
            catch
            {
                MessageBoxRTL.Error("افزودن منشی با خطا مواجه شد لطفا دوباره تلاش کنید", "");
            }
        }

        private void AddSecretary_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
