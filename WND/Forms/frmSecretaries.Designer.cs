
using BaseFormLibrary;
using System.Windows.Forms;

namespace WND.Forms
{
    partial class frmSecretaries : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecretaries));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new Utility.SizableTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSecretaryPhone = new Utility.NumericTextBox();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.txtSecretaryName = new Utility.SizableTextBox();
            this.txtSecretaryUsername = new Utility.SizableTextBox();
            this.txtSecretaryPassword = new Utility.SizableTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(196, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1060, 551);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(208, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(213, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(481, 185);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(292, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(733, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 23);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(493, 190);
            this.txtSearch.MaxLength = 75;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 24);
            this.txtSearch.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.Location = new System.Drawing.Point(1065, 611);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 35);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(1065, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 79);
            this.btnSave.TabIndex = 59;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtSecretaryPhone
            // 
            this.txtSecretaryPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecretaryPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.txtSecretaryPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretaryPhone.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSecretaryPhone.Location = new System.Drawing.Point(909, 477);
            this.txtSecretaryPhone.MaxLength = 11;
            this.txtSecretaryPhone.Multiline = true;
            this.txtSecretaryPhone.Name = "txtSecretaryPhone";
            this.txtSecretaryPhone.Size = new System.Drawing.Size(80, 28);
            this.txtSecretaryPhone.TabIndex = 89;
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.lblDateJoined.Font = new System.Drawing.Font("IRANYekan", 6F);
            this.lblDateJoined.Location = new System.Drawing.Point(1044, 478);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(79, 28);
            this.lblDateJoined.TabIndex = 90;
            // 
            // txtSecretaryName
            // 
            this.txtSecretaryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecretaryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.txtSecretaryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretaryName.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSecretaryName.Location = new System.Drawing.Point(909, 426);
            this.txtSecretaryName.MaxLength = 75;
            this.txtSecretaryName.Multiline = true;
            this.txtSecretaryName.Name = "txtSecretaryName";
            this.txtSecretaryName.Size = new System.Drawing.Size(214, 28);
            this.txtSecretaryName.TabIndex = 91;
            // 
            // txtSecretaryUsername
            // 
            this.txtSecretaryUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecretaryUsername.BackColor = System.Drawing.Color.White;
            this.txtSecretaryUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretaryUsername.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSecretaryUsername.Location = new System.Drawing.Point(932, 562);
            this.txtSecretaryUsername.MaxLength = 75;
            this.txtSecretaryUsername.Multiline = true;
            this.txtSecretaryUsername.Name = "txtSecretaryUsername";
            this.txtSecretaryUsername.Size = new System.Drawing.Size(107, 28);
            this.txtSecretaryUsername.TabIndex = 92;
            // 
            // txtSecretaryPassword
            // 
            this.txtSecretaryPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecretaryPassword.BackColor = System.Drawing.Color.White;
            this.txtSecretaryPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretaryPassword.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSecretaryPassword.Location = new System.Drawing.Point(932, 605);
            this.txtSecretaryPassword.MaxLength = 75;
            this.txtSecretaryPassword.Multiline = true;
            this.txtSecretaryPassword.Name = "txtSecretaryPassword";
            this.txtSecretaryPassword.Size = new System.Drawing.Size(107, 28);
            this.txtSecretaryPassword.TabIndex = 93;
            // 
            // frmSecretaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtSecretaryPassword);
            this.Controls.Add(this.txtSecretaryUsername);
            this.Controls.Add(this.txtSecretaryName);
            this.Controls.Add(this.lblDateJoined);
            this.Controls.Add(this.txtSecretaryPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSecretaries";
            this.ShowIcon = false;
            this.Text = "منشی‌ها";
            this.Controls.SetChildIndex(this.btnDashboard, 0);
            this.Controls.SetChildIndex(this.btnDrivers, 0);
            this.Controls.SetChildIndex(this.btnServices, 0);
            this.Controls.SetChildIndex(this.btnPaths, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtSecretaryPhone, 0);
            this.Controls.SetChildIndex(this.lblDateJoined, 0);
            this.Controls.SetChildIndex(this.txtSecretaryName, 0);
            this.Controls.SetChildIndex(this.txtSecretaryUsername, 0);
            this.Controls.SetChildIndex(this.txtSecretaryPassword, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnSearch;
        public Utility.SizableTextBox txtSearch;
        private Button btnCancel;
        private Button btnSave;
        public Utility.NumericTextBox txtSecretaryPhone;
        public Label lblDateJoined;
        public Utility.SizableTextBox txtSecretaryName;
        public Utility.SizableTextBox txtSecretaryUsername;
        public Utility.SizableTextBox txtSecretaryPassword;
    }
}