using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using WND.Models;
using WND.Utility;

namespace WND
{

    public partial class PasswordForgetion : Form
    {

        private TaxiDbContext taxiDbContext = new TaxiDbContext();
        AuthenticatedUser user;
        public PasswordForgetion()
        {
            InitializeComponent();
        }

        public PasswordForgetion(string username)
        {
            user = taxiDbContext.AuthenticatedUsers.FirstOrDefault(au => au.Username == username);
            InitializeComponent();
            if (user != null)
            {
                txtSecurityQuestion.Text = user.SecurityQuestion;
            }
        }

        private void PasswordForgetion_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordRepeation.Text && Validation.ValidatePassword(txtPassword.Text))
            {
                user.Password = EasyHash.Hash(txtPassword.Text);
                try
                {
                    taxiDbContext.AuthenticatedUsers.AddOrUpdate(user);
                    taxiDbContext.SaveChanges();
                    MessageBoxRTL.Info("کلمه عبور شما با موفقیت تغییر یافت.", string.Empty);
                    this.Close();
                }
                catch
                {
                    MessageBoxRTL.Error("عملیات تغییر کلمه عبور موفقیت آمیز نبود. لطفا مجددا تلاش نمایید.", "خطا");
                }
            }
            else
            {
                MessageBoxRTL.Error("کلمه عبور باید حداقل 8 کاراکتر شامل حداقل یک حرف بزرگ، یک حرف کوچک و یک عدد باشد","خطا");
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text != string.Empty)
            {
                if (user.SecurityAnswer == txtSecurityAnswer.Text)
                {
                    txtPassword.Enabled = true;
                    txtPasswordRepeation.Enabled = true;
                    btnChangePassword.Enabled = true;
                }
            }
        }

        private void checkboxTogglePasswordDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxTogglePasswordDisplay.Checked)
            {
                txtPassword.PasswordChar = new char();
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

    }
}
