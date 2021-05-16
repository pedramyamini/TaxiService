using BaseFormLibrary;
using Utility;

namespace WND
{
    partial class PasswordForgetion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSecurityQuestion = new Utility.SizableTextBox();
            this.txtSecurityAnswer = new Utility.SizableTextBox();
            this.txtPassword = new Utility.SizableTextBox();
            this.txtPasswordRepeation = new Utility.SizableTextBox();
            this.btnChangePassword = new System.Windows.Forms.PictureBox();
            this.btnVerify = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkboxTogglePasswordDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxTogglePasswordDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecurityQuestion.Font = new System.Drawing.Font("IRANYekan", 12F);
            this.txtSecurityQuestion.Location = new System.Drawing.Point(117, 13);
            this.txtSecurityQuestion.Multiline = true;
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.ReadOnly = true;
            this.txtSecurityQuestion.Size = new System.Drawing.Size(177, 44);
            this.txtSecurityQuestion.TabIndex = 1;
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecurityAnswer.Font = new System.Drawing.Font("IRANYekan", 12F);
            this.txtSecurityAnswer.Location = new System.Drawing.Point(117, 79);
            this.txtSecurityAnswer.Multiline = true;
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(177, 44);
            this.txtSecurityAnswer.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("IRANYekan", 12F);
            this.txtPassword.Location = new System.Drawing.Point(126, 261);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(123, 44);
            this.txtPassword.TabIndex = 3;
            // 
            // txtPasswordRepeation
            // 
            this.txtPasswordRepeation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordRepeation.Font = new System.Drawing.Font("IRANYekan", 12F);
            this.txtPasswordRepeation.Location = new System.Drawing.Point(126, 319);
            this.txtPasswordRepeation.Multiline = true;
            this.txtPasswordRepeation.Name = "txtPasswordRepeation";
            this.txtPasswordRepeation.PasswordChar = '*';
            this.txtPasswordRepeation.Size = new System.Drawing.Size(153, 44);
            this.txtPasswordRepeation.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Image = global::WND.Properties.Resources.Group_105__2_;
            this.btnChangePassword.Location = new System.Drawing.Point(91, 386);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(171, 39);
            this.btnChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.TabStop = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Image = global::WND.Properties.Resources.Group_1092;
            this.btnVerify.Location = new System.Drawing.Point(117, 138);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(116, 32);
            this.btnVerify.TabIndex = 5;
            this.btnVerify.TabStop = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WND.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkboxTogglePasswordDisplay
            // 
            this.checkboxTogglePasswordDisplay.BackColor = System.Drawing.Color.White;
            this.checkboxTogglePasswordDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxTogglePasswordDisplay.Image = global::WND.Properties.Resources.Group_108;
            this.checkboxTogglePasswordDisplay.Location = new System.Drawing.Point(252, 269);
            this.checkboxTogglePasswordDisplay.Name = "checkboxTogglePasswordDisplay";
            this.checkboxTogglePasswordDisplay.Size = new System.Drawing.Size(30, 27);
            this.checkboxTogglePasswordDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checkboxTogglePasswordDisplay.TabIndex = 16;
            this.checkboxTogglePasswordDisplay.TabStop = false;
            this.checkboxTogglePasswordDisplay.Click += new System.EventHandler(this.checkboxTogglePasswordDisplay_Click);
            // 
            // PasswordForgetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 447);
            this.Controls.Add(this.checkboxTogglePasswordDisplay);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtPasswordRepeation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.txtSecurityQuestion);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "PasswordForgetion";
            this.ShowIcon = false;
            this.Text = "بازیابی کلمه عبور";
            this.Load += new System.EventHandler(this.PasswordForgetion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkboxTogglePasswordDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public SizableTextBox txtSecurityQuestion;
        public SizableTextBox txtSecurityAnswer;
        public SizableTextBox txtPassword;
        public SizableTextBox txtPasswordRepeation;
        public System.Windows.Forms.PictureBox btnVerify;
        public System.Windows.Forms.PictureBox btnChangePassword;
        public System.Windows.Forms.PictureBox checkboxTogglePasswordDisplay;
    }
}