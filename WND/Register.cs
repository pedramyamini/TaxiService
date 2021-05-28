using BaseFormLibrary;
using System;
using System.Linq;
using System.Windows.Forms;
using WND.Data;
using Models;
using Utility;


namespace WND
{
    public partial class Register : RegisterForm
    {
        public Register()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkboxTogglePasswordDisplay_CheckedChanged(object sender, EventArgs e)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecurityQuestion.Text) || string.IsNullOrEmpty(txtSecurityAnswer.Text))
            {
                MessageBoxRTL.Error("وارد کردن سوال امنیتی و پاسخ آن ضروری است", string.Empty);
                return;
            }
            if (!TaxiDbContext.Instance.AuthenticatedUsers.Any())
            {
                AuthenticatedUser user = new AuthenticatedUser()
                {
                    FullName = txtFullName.Text,
                    Mobile = txtMobile.Text.PersianToEnglish(),
                    Username = txtUsername.Text,
                    Password = EasyHash.Hash(txtPassword.Text),
                    Role = Roles.Admin,
                    SecurityQuestion = txtSecurityQuestion.Text,
                    SecurityAnswer = EasyHash.Hash(txtSecurityAnswer.Text),
                };
                if (Validation.Validate(user) & Validation.ValidatePassword(txtPassword.Text))
                {
                    TaxiDbContext.Instance.AuthenticatedUsers.Add(user);
                    TaxiDbContext.Instance.SaveChanges();
                    Utility.MessageBoxRTL.Info("ثبت نام مدیر با موفقیت انجام شد.اکنون می‌توانید وارد حساب کاربری‌تان شوید.", "ثبت نام");
                    this.Hide();
                    new Login();
                    Session.RecentlyLogedIn = true;
                }
            }
        }

        

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            MessageBoxRTL.Info("با شماره 09182871349 تماس بگیرید", string.Empty);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.ResetText());
        }
    }
}
