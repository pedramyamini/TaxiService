﻿namespace WND
{
    partial class Register
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
            this.panelRegister = new System.Windows.Forms.Panel();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxTogglePasswordDisplay = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.txtSecurityAnswer);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.txtSecurityQuestion);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.checkboxTogglePasswordDisplay);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.txtPassword);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.txtUsername);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Location = new System.Drawing.Point(42, 37);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelRegister.Size = new System.Drawing.Size(268, 288);
            this.panelRegister.TabIndex = 11;
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer.Location = new System.Drawing.Point(20, 181);
            this.txtSecurityAnswer.MaxLength = 20;
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(165, 26);
            this.txtSecurityAnswer.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(190, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "پاسخ امنیتی";
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityQuestion.Location = new System.Drawing.Point(20, 146);
            this.txtSecurityQuestion.MaxLength = 20;
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(165, 26);
            this.txtSecurityQuestion.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(190, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "سوال امنیتی";
            // 
            // checkboxTogglePasswordDisplay
            // 
            this.checkboxTogglePasswordDisplay.AutoSize = true;
            this.checkboxTogglePasswordDisplay.Location = new System.Drawing.Point(20, 100);
            this.checkboxTogglePasswordDisplay.Name = "checkboxTogglePasswordDisplay";
            this.checkboxTogglePasswordDisplay.Size = new System.Drawing.Size(100, 17);
            this.checkboxTogglePasswordDisplay.TabIndex = 16;
            this.checkboxTogglePasswordDisplay.Text = "نمایش کلمه عبور";
            this.checkboxTogglePasswordDisplay.UseVisualStyleBackColor = true;
            this.checkboxTogglePasswordDisplay.CheckedChanged += new System.EventHandler(this.checkboxTogglePasswordDisplay_CheckedChanged_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(92, 224);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(97, 40);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "ثبت نام";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(20, 52);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 26);
            this.txtPassword.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(203, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "کلمه عبور";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(20, 20);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(165, 26);
            this.txtUsername.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(197, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "نام کاربری";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WND.Properties.Resources.OIP1;
            this.ClientSize = new System.Drawing.Size(351, 361);
            this.Controls.Add(this.panelRegister);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 400);
            this.MinimumSize = new System.Drawing.Size(367, 400);
            this.Name = "Register";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ثبت نام";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.CheckBox checkboxTogglePasswordDisplay;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecurityQuestion;
        private System.Windows.Forms.Label label3;
    }
}