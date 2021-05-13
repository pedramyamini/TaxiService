using BaseFormLibrary;
using Models;
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
using Utility;


namespace WND
{
    public partial class Login : BaseFormLibrary.LoginForm
    {
        public Login()
        {

        }

        //private void checkboxTogglePasswordDisplay_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkboxTogglePasswordDisplay.Checked)
        //    {
        //        txtPassword.PasswordChar = new char();
        //    }
        //    else
        //    {
        //        txtPassword.PasswordChar = '*';
        //    }
        //}

        //private void btnRestorePassword_Click(object sender, EventArgs e)
        //{
        //    if(txtUsername.Text!=string.Empty)
        //    {
        //        if(TaxiDbContext.Instance.AuthenticatedUsers.FirstOrDefault(au=>au.Username==txtUsername.Text)!=null)
        //        {
        //            new PasswordForgetion(txtUsername.Text).Show();
        //        }
        //        else
        //        {
        //            MessageBoxRTL.Error("از صحت نام کاربری اطمینان حاصل کنید", "خطا");
        //        }
        //    }
        //    else
        //    {
        //        MessageBoxRTL.Error("نام کاربری نمی‌تواند خالی باشد", "خطا");
        //    }
            
        //}


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        public override void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                string Password = EasyHash.Hash(txtPassword.Text);
                Session.CurrentUser = TaxiDbContext.Instance.AuthenticatedUsers.FirstOrDefault(au => au.Username == txtUsername.Text && au.Password == Password);
                if (Session.CurrentUser != null)
                {
                    MessageBoxRTL.Info(string.Format("کاربر گرامی، {0} خوش آمدید", Session.CurrentUser.Username), "");
                    //checking Role
                    switch (Session.CurrentUser.Role)
                    {
                        case Roles.Admin:
                            new ManagerPanel();
                            break;
                        case Roles.Secretary:
                            new SecretaryPanel();
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

            base.btnLogin_Click(sender, e);

        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)this.btnContactUs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxTogglePasswordDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkboxTogglePasswordDisplay
            // 
            this.checkboxTogglePasswordDisplay.Location = new System.Drawing.Point(1050, 493);
            this.checkboxTogglePasswordDisplay.Size = new System.Drawing.Size(31, 30);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(934, 429);
            this.txtUsername.Size = new System.Drawing.Size(145, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(932, 490);
            this.txtPassword.Size = new System.Drawing.Size(115, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // btnRestorePassword
            // 
            this.btnRestorePassword.FlatAppearance.BorderSize = 0;
            this.btnRestorePassword.Click += new System.EventHandler(this.btnRestorePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(1354, 710);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1354, 710);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btnContactUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxTogglePasswordDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRestorePassword_Click_1(object sender, EventArgs e)
        {
            new PasswordForgetion();
        }

        protected override void btnRestorePassword_Click(object sender, EventArgs e)
        {
            if(TaxiDbContext.Instance.AuthenticatedUsers.Any(u=>u.Username==txtUsername.Text))
            {
                new PasswordForgetion(txtUsername.Text);
            }
            else
            {
                MessageBoxRTL.Error("کاربری با این مشخصات یافت نشد", string.Empty);
            }
        }


        //private void Login_EnabledChanged(object sender, EventArgs e)
        //{
        //    txtUsername.Text = string.Empty;
        //    txtPassword.Text = string.Empty;
        //}



        //private void pictureBox2_Click(object sender, EventArgs e)
        //{

        //}

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Login
        //    // 
        //    this.ClientSize = new System.Drawing.Size(1370, 749);
        //    this.Location = new System.Drawing.Point(0, 0);
        //    this.Name = "Login";
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
    }
}
