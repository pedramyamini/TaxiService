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
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordRepeation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.checkboxTogglePasswordDisplay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityAnswer.Location = new System.Drawing.Point(112, 62);
            this.txtSecurityAnswer.MaxLength = 20;
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(163, 26);
            this.txtSecurityAnswer.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "پاسخ امنیتی";
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityQuestion.Location = new System.Drawing.Point(112, 27);
            this.txtSecurityQuestion.MaxLength = 20;
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.ReadOnly = true;
            this.txtSecurityQuestion.Size = new System.Drawing.Size(163, 26);
            this.txtSecurityQuestion.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(31, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "سوال امنیتی";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(112, 158);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 26);
            this.txtPassword.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "کلمه عبور جدید";
            // 
            // txtPasswordRepeation
            // 
            this.txtPasswordRepeation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordRepeation.Enabled = false;
            this.txtPasswordRepeation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordRepeation.Location = new System.Drawing.Point(112, 193);
            this.txtPasswordRepeation.MaxLength = 20;
            this.txtPasswordRepeation.Name = "txtPasswordRepeation";
            this.txtPasswordRepeation.PasswordChar = '*';
            this.txtPasswordRepeation.Size = new System.Drawing.Size(163, 26);
            this.txtPasswordRepeation.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "تکرار کلمه عبور";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Location = new System.Drawing.Point(101, 286);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(89, 38);
            this.btnChangePassword.TabIndex = 30;
            this.btnChangePassword.Text = "تغییر کلمه عبور";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(102, 105);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(89, 38);
            this.btnVerify.TabIndex = 31;
            this.btnVerify.Text = "صحت سنجی";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // checkboxTogglePasswordDisplay
            // 
            this.checkboxTogglePasswordDisplay.AutoSize = true;
            this.checkboxTogglePasswordDisplay.Location = new System.Drawing.Point(175, 239);
            this.checkboxTogglePasswordDisplay.Name = "checkboxTogglePasswordDisplay";
            this.checkboxTogglePasswordDisplay.Size = new System.Drawing.Size(100, 17);
            this.checkboxTogglePasswordDisplay.TabIndex = 32;
            this.checkboxTogglePasswordDisplay.Text = "نمایش کلمه عبور";
            this.checkboxTogglePasswordDisplay.UseVisualStyleBackColor = true;
            this.checkboxTogglePasswordDisplay.CheckedChanged += new System.EventHandler(this.checkboxTogglePasswordDisplay_CheckedChanged);
            // 
            // PasswordForgetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 347);
            this.Controls.Add(this.checkboxTogglePasswordDisplay);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtPasswordRepeation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecurityQuestion);
            this.Controls.Add(this.label3);
            this.Name = "PasswordForgetion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بازیابی کلمه عبور";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordForgetion_FormClosing);
            this.Load += new System.EventHandler(this.PasswordForgetion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecurityQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordRepeation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.CheckBox checkboxTogglePasswordDisplay;
    }
}