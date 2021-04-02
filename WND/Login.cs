using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    public partial class Login : Form
    {
        private ITaxiDbContext taxiContext;
        public Login(ITaxiDbContext _taxiContext)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
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

        private void btnRestorePassword_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text!=string.Empty)
            {
                if(taxiContext.AuthenticatedUsers.FirstOrDefault(au=>au.Username==txtUsername.Text)!=null)
                {
                    new PasswordForgetion(txtUsername.Text).Show();
                }
                else
                {
                    MessageBoxRTL.Error("از صحت نام کاربری اطمینان حاصل کنید", "خطا");
                }
            }
            else
            {
                MessageBoxRTL.Error("نام کاربری نمی‌تواند خالی باشد", "خطا");
            }
            
        }


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_EnabledChanged(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                string Password = EasyHash.Hash(txtPassword.Text);
                Session.CurrentUser = taxiContext.AuthenticatedUsers.FirstOrDefault(au => au.Username == txtUsername.Text && au.Password == Password);
                if (Session.CurrentUser != null)
                {
                    MessageBoxRTL.Info(string.Format("کاربر گرامی، {0} خوش آمدید", Session.CurrentUser.Username), "");
                    //checking Role
                    switch (Session.CurrentUser.Role)
                    {
                        case Roles.Admin:
                            new ManagerPanel(taxiContext, this).Show();
                            this.Enabled = false;
                            this.Hide();
                            break;
                        case Roles.Secretary:
                            new SecretaryPanel(taxiContext, this).Show();
                            this.Enabled = false;
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBoxRTL.Info("کاربری با این مشخصات یافت نشد. لطفا از صحت نام کاربری و کلمه عبور خود اطمینان حاصل نمایید", "");
                }
            }
            else
            {
                MessageBoxRTL.Info("نام کاربری و کلمه عبور نمی‌تواند خالی باشد", "");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
