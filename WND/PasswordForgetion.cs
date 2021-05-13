using BaseFormLibrary;
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
using Models;
using Utility;


namespace WND
{

    public partial class PasswordForgetion : ClosableForm
    {

        AuthenticatedUser user;
        public PasswordForgetion()
        {

        }

        public PasswordForgetion(string username)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(
                t => t.BackColor = Color.FromArgb(244, 244, 241));

            user = TaxiDbContext.Instance.AuthenticatedUsers.FirstOrDefault(au => au.Username == username);
            
            InitializeComponent();
            this.Show();

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
                    TaxiDbContext.Instance.AuthenticatedUsers.AddOrUpdate(user);
                    TaxiDbContext.Instance.SaveChanges();
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
                MessageBoxRTL.Error("کلمه عبور باید حداقل 8 کاراکتر شامل حداقل یک حرف بزرگ، یک حرف کوچک و یک عدد باشد", "خطا");
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text != string.Empty)
            {
                if (user.SecurityAnswer == EasyHash.Hash(txtSecurityAnswer.Text))
                {
                    btnChangePassword.Enabled = true;
                }
            }
        }

        private void checkboxTogglePasswordDisplay_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
