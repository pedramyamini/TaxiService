using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BaseFormLibrary
{
    public class LoginForm:Form
    {
        public PictureBox btnContactUs;
        public PictureBox btnExit;
        public Button btnRestorePassword;
        public Label lbl1;
        public PictureBox btnLogin;
        public PictureBox btnReset;
        public PictureBox checkboxTogglePasswordDisplay;
        public SizableTextBox txtPassword;
        public SizableTextBox txtUsername;
        public PictureBox pictureBox1;
        
        public LoginForm()
        {
            this.Size = new System.Drawing.Size(1386,768);
            this.WindowState = FormWindowState.Maximized;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.InitializeComponent();
            this.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.OK)
            {
                
            }
            else
            {
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }

        private void InitializeComponent()
        {
            this.btnContactUs = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnRestorePassword = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.checkboxTogglePasswordDisplay = new System.Windows.Forms.PictureBox();
            this.txtPassword = new BaseFormLibrary.SizableTextBox();
            this.txtUsername = new BaseFormLibrary.SizableTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnContactUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxTogglePasswordDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContactUs
            // 
            this.btnContactUs.BackColor = System.Drawing.Color.White;
            this.btnContactUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContactUs.Image = global::BaseFormLibrary.Properties.Resources.Group_109;
            this.btnContactUs.Location = new System.Drawing.Point(103, 672);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(78, 81);
            this.btnContactUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnContactUs.TabIndex = 1;
            this.btnContactUs.TabStop = false;
            this.btnContactUs.Click += new System.EventHandler(this.btnContactUs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BaseFormLibrary.Properties.Resources.Login__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 710);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::BaseFormLibrary.Properties.Resources.Group_111;
            this.btnExit.Location = new System.Drawing.Point(19, 672);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 81);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestorePassword
            // 
            this.btnRestorePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnRestorePassword.FlatAppearance.BorderSize = 0;
            this.btnRestorePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestorePassword.Font = new System.Drawing.Font("IRANYekan", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRestorePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(56)))));
            this.btnRestorePassword.Location = new System.Drawing.Point(932, 626);
            this.btnRestorePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestorePassword.Name = "btnRestorePassword";
            this.btnRestorePassword.Size = new System.Drawing.Size(109, 26);
            this.btnRestorePassword.TabIndex = 13;
            this.btnRestorePassword.Text = "بازیابی کلمه عبور";
            this.btnRestorePassword.UseVisualStyleBackColor = false;
            this.btnRestorePassword.Click += new System.EventHandler(this.btnRestorePassword_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.lbl1.Font = new System.Drawing.Font("IRANYekan", 8F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(56)))));
            this.lbl1.Location = new System.Drawing.Point(909, 603);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl1.Size = new System.Drawing.Size(155, 19);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "رمز عبور خود را فراموش کرده‌اید؟";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = global::BaseFormLibrary.Properties.Resources.Group_104;
            this.btnLogin.Location = new System.Drawing.Point(908, 538);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 47);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogin.TabIndex = 12;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::BaseFormLibrary.Properties.Resources.Group_107;
            this.btnReset.Location = new System.Drawing.Point(1003, 541);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(52, 43);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReset.TabIndex = 9;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // checkboxTogglePasswordDisplay
            // 
            this.checkboxTogglePasswordDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.checkboxTogglePasswordDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxTogglePasswordDisplay.Image = global::BaseFormLibrary.Properties.Resources.Group_108;
            this.checkboxTogglePasswordDisplay.Location = new System.Drawing.Point(1060, 497);
            this.checkboxTogglePasswordDisplay.Name = "checkboxTogglePasswordDisplay";
            this.checkboxTogglePasswordDisplay.Size = new System.Drawing.Size(27, 26);
            this.checkboxTogglePasswordDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkboxTogglePasswordDisplay.TabIndex = 3;
            this.checkboxTogglePasswordDisplay.TabStop = false;
            this.checkboxTogglePasswordDisplay.Click += new System.EventHandler(this.checkboxTogglePasswordDisplay_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("IRANYekan", 14F);
            this.txtPassword.Location = new System.Drawing.Point(938, 491);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(117, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Pedr@m1378";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(87)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("IRANYekan", 14F);
            this.txtUsername.Location = new System.Drawing.Point(941, 429);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(141, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Pedram";
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(1354, 710);
            this.Controls.Add(this.btnRestorePassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.checkboxTogglePasswordDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContactUs);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.btnContactUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxTogglePasswordDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public virtual void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
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
            if(txtPassword.PasswordChar=='*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        protected virtual void btnRestorePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
