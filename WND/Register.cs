using System;
using System.Linq;
using System.Windows.Forms;
using WND.Data;
using WND.Models;
using WND.Utility;

namespace WND
{
    public partial class Register : Form
    {
        private ITaxiDbContext taxiContext;
        public Register(ITaxiDbContext _taxiContext)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!taxiContext.AuthenticatedUsers.Any())
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
                    taxiContext.AuthenticatedUsers.Add(user);
                    taxiContext.SaveChanges();
                    MessageBoxRTL.Info("ثبت نام مدیر با موفقیت انجام شد.اکنون می‌توانید وارد حساب کاربری‌تان شوید.", "ثبت نام");
                    this.Hide();
                    new ManagerPanel(taxiContext, this).Show();
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
    }
}
