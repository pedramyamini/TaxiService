using BaseFormLibrary;

namespace WND
{
    partial class Login : LoginForm
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
    //    private void InitializeComponent()
    //    {
    //        this.btnRestorePassword = new System.Windows.Forms.Button();
    //        this.panelRegister = new System.Windows.Forms.Panel();
    //        this.btnRegister = new System.Windows.Forms.Button();
    //        this.label2 = new System.Windows.Forms.Label();
    //        this.label1 = new System.Windows.Forms.Label();
    //        this.checkboxTogglePasswordDisplay = new System.Windows.Forms.CheckBox();
    //        this.txtPassword = new System.Windows.Forms.TextBox();
    //        this.txtUsername = new System.Windows.Forms.TextBox();
    //        this.panelRegister.SuspendLayout();
    //        this.SuspendLayout();
    //        // 
    //        // btnRestorePassword
    //        // 
    //        this.btnRestorePassword.BackColor = System.Drawing.Color.Black;
    //        this.btnRestorePassword.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.btnRestorePassword.ForeColor = System.Drawing.Color.White;
    //        this.btnRestorePassword.Location = new System.Drawing.Point(5, 130);
    //        this.btnRestorePassword.Name = "btnRestorePassword";
    //        this.btnRestorePassword.Size = new System.Drawing.Size(115, 40);
    //        this.btnRestorePassword.TabIndex = 18;
    //        this.btnRestorePassword.Text = "بازیابی کلمه عبور";
    //        this.btnRestorePassword.UseVisualStyleBackColor = false;
    //        this.btnRestorePassword.Click += new System.EventHandler(this.btnRestorePassword_Click);
    //        // 
    //        // panelRegister
    //        // 
    //        this.panelRegister.Controls.Add(this.btnRestorePassword);
    //        this.panelRegister.Controls.Add(this.btnRegister);
    //        this.panelRegister.Controls.Add(this.label2);
    //        this.panelRegister.Controls.Add(this.label1);
    //        this.panelRegister.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.panelRegister.Location = new System.Drawing.Point(76, 156);
    //        this.panelRegister.Name = "panelRegister";
    //        this.panelRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
    //        this.panelRegister.Size = new System.Drawing.Size(268, 241);
    //        this.panelRegister.TabIndex = 19;
    //        // 
    //        // btnRegister
    //        // 
    //        this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(188)))), ((int)(((byte)(28)))));
    //        this.btnRegister.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.btnRegister.ForeColor = System.Drawing.Color.Black;
    //        this.btnRegister.Location = new System.Drawing.Point(137, 130);
    //        this.btnRegister.Name = "btnRegister";
    //        this.btnRegister.Size = new System.Drawing.Size(115, 40);
    //        this.btnRegister.TabIndex = 3;
    //        this.btnRegister.Text = "ورود";
    //        this.btnRegister.UseVisualStyleBackColor = false;
    //        this.btnRegister.Click += new System.EventHandler(this.btnLogin_Click);
    //        // 
    //        // label2
    //        // 
    //        this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
    //        this.label2.AutoSize = true;
    //        this.label2.BackColor = System.Drawing.Color.Transparent;
    //        this.label2.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label2.ForeColor = System.Drawing.Color.White;
    //        this.label2.Location = new System.Drawing.Point(193, 50);
    //        this.label2.Name = "label2";
    //        this.label2.Size = new System.Drawing.Size(62, 22);
    //        this.label2.TabIndex = 13;
    //        this.label2.Text = "کلمه عبور";
    //        // 
    //        // label1
    //        // 
    //        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
    //        this.label1.AutoSize = true;
    //        this.label1.BackColor = System.Drawing.Color.Transparent;
    //        this.label1.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.label1.ForeColor = System.Drawing.Color.White;
    //        this.label1.Location = new System.Drawing.Point(193, 17);
    //        this.label1.Name = "label1";
    //        this.label1.Size = new System.Drawing.Size(65, 22);
    //        this.label1.TabIndex = 11;
    //        this.label1.Text = "نام کاربری";
    //        // 
    //        // checkboxTogglePasswordDisplay
    //        // 
    //        this.checkboxTogglePasswordDisplay.AutoSize = true;
    //        this.checkboxTogglePasswordDisplay.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.checkboxTogglePasswordDisplay.ForeColor = System.Drawing.Color.White;
    //        this.checkboxTogglePasswordDisplay.Location = new System.Drawing.Point(20, 82);
    //        this.checkboxTogglePasswordDisplay.Name = "checkboxTogglePasswordDisplay";
    //        this.checkboxTogglePasswordDisplay.Size = new System.Drawing.Size(122, 26);
    //        this.checkboxTogglePasswordDisplay.TabIndex = 16;
    //        this.checkboxTogglePasswordDisplay.Text = "نمایش کلمه عبور";
    //        this.checkboxTogglePasswordDisplay.UseVisualStyleBackColor = true;
    //        this.checkboxTogglePasswordDisplay.CheckedChanged += new System.EventHandler(this.checkboxTogglePasswordDisplay_CheckedChanged);
    //        // 
    //        // txtPassword
    //        // 
    //        this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
    //        this.txtPassword.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.txtPassword.Location = new System.Drawing.Point(20, 46);
    //        this.txtPassword.MaxLength = 20;
    //        this.txtPassword.Name = "txtPassword";
    //        this.txtPassword.PasswordChar = '*';
    //        this.txtPassword.Size = new System.Drawing.Size(165, 30);
    //        this.txtPassword.TabIndex = 2;
    //        this.txtPassword.Text = "Pedr@m1378";
    //        // 
    //        // txtUsername
    //        // 
    //        this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
    //        this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
    //        this.txtUsername.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.txtUsername.Location = new System.Drawing.Point(20, 14);
    //        this.txtUsername.MaxLength = 20;
    //        this.txtUsername.Name = "txtUsername";
    //        this.txtUsername.Size = new System.Drawing.Size(165, 30);
    //        this.txtUsername.TabIndex = 1;
    //        this.txtUsername.Text = "secretary";
    //        // 
    //        // Login
    //        // 
    //        this.AcceptButton = this.btnRegister;
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.BackColor = System.Drawing.SystemColors.Control;
    //        this.ClientSize = new System.Drawing.Size(940, 497);
    //        this.Controls.Add(this.panelRegister);
    //        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
    //        this.Location = new System.Drawing.Point(0, 0);
    //        this.Name = "Login";
    //        this.ShowIcon = false;
    //        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    //        this.Text = "ورود";
    //        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
    //        this.Load += new System.EventHandler(this.Login_Load);
    //        this.EnabledChanged += new System.EventHandler(this.Login_EnabledChanged);
    //        this.Controls.SetChildIndex(this.panelRegister, 0);
    //        this.panelRegister.ResumeLayout(false);
    //        this.panelRegister.PerformLayout();
    //        this.ResumeLayout(false);
    //        this.PerformLayout();

    //    }

        #endregion

    //    private System.Windows.Forms.Button btnRestorePassword;
    //    private System.Windows.Forms.Panel panelRegister;
    //    private System.Windows.Forms.CheckBox checkboxTogglePasswordDisplay;
    //    private System.Windows.Forms.Button btnRegister;
    //    private System.Windows.Forms.TextBox txtPassword;
    //    private System.Windows.Forms.Label label2;
    //    private System.Windows.Forms.TextBox txtUsername;
    //    private System.Windows.Forms.Label label1;
    }
}