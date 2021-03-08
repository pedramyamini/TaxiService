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
        private TaxiDbContext taxiContext = new TaxiDbContext();
        public Register()
        {
            InitializeComponent();
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
            if(txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                if (!taxiContext.AuthenticatedUsers.Any())
                {
                    if (Validation.ValidatePassword(txtPassword.Text))
                    {
                        string Username = txtUsername.Text;
                        string Password = EasyHash.Hash(txtPassword.Text);
                        taxiContext.AuthenticatedUsers.Add(new AuthenticatedUser()
                        {
                            Username = Username,
                            Password = Password,
                            Role = Roles.Admin,
                            SecurityQuestion = txtSecurityQuestion.Text,
                            SecurityAnswer = txtSecurityAnswer.Text,
                        });
                        taxiContext.SaveChanges();
                        MessageBoxRTL.Info("ثبت نام مدیر با موفقیت انجام شد.اکنون می‌توانید وارد حساب کاربری‌تان شوید.", "ثبت نام");
                        this.Hide();
                        new ManagerPanel().Show();
                    }
                }
            }
        }

        private void checkboxTogglePasswordDisplay_CheckedChanged_1(object sender, EventArgs e)
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

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
