using BaseFormLibrary;

namespace WND.Forms
{
    partial class frmDrivers : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbDriver = new System.Windows.Forms.RadioButton();
            this.rdbDateJoined = new System.Windows.Forms.RadioButton();
            this.txtSearch = new Utility.SizableTextBox();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.txtSharePercent = new Utility.NumericTextBox();
            this.txtDriverName = new Utility.SizableTextBox();
            this.comboboxCarModel = new System.Windows.Forms.ComboBox();
            this.comboboxCarColor = new System.Windows.Forms.ComboBox();
            this.txtDriverPhone = new Utility.SizableTextBox();
            this.txtLicencePlate4 = new Utility.NumericTextBox();
            this.txtLicencePlate1 = new Utility.NumericTextBox();
            this.txtLicencePlate3 = new Utility.NumericTextBox();
            this.txtLicencePlate2 = new Utility.SizableTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.CarPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1123, 374);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(199, 486);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1123, 241);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
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
            this.btnSearch.Location = new System.Drawing.Point(1021, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 25);
            this.btnSearch.TabIndex = 80;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // rdbDriver
            // 
            this.rdbDriver.AutoSize = true;
            this.rdbDriver.BackColor = System.Drawing.Color.White;
            this.rdbDriver.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDriver.Location = new System.Drawing.Point(670, 152);
            this.rdbDriver.Name = "rdbDriver";
            this.rdbDriver.Size = new System.Drawing.Size(65, 21);
            this.rdbDriver.TabIndex = 79;
            this.rdbDriver.TabStop = true;
            this.rdbDriver.Text = "نام راننده";
            this.rdbDriver.UseVisualStyleBackColor = false;
            // 
            // rdbDateJoined
            // 
            this.rdbDateJoined.AutoSize = true;
            this.rdbDateJoined.BackColor = System.Drawing.Color.White;
            this.rdbDateJoined.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDateJoined.Location = new System.Drawing.Point(741, 152);
            this.rdbDateJoined.Name = "rdbDateJoined";
            this.rdbDateJoined.Size = new System.Drawing.Size(83, 21);
            this.rdbDateJoined.TabIndex = 78;
            this.rdbDateJoined.TabStop = true;
            this.rdbDateJoined.Text = "تاریخ عضویت";
            this.rdbDateJoined.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("IRANYekan", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(858, 152);
            this.txtSearch.MaxLength = 75;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 25);
            this.txtSearch.TabIndex = 81;
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblDateJoined.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDateJoined.Location = new System.Drawing.Point(300, 664);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(85, 28);
            this.lblDateJoined.TabIndex = 82;
            // 
            // txtSharePercent
            // 
            this.txtSharePercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtSharePercent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSharePercent.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSharePercent.Location = new System.Drawing.Point(444, 664);
            this.txtSharePercent.MaxLength = 3;
            this.txtSharePercent.Multiline = true;
            this.txtSharePercent.Name = "txtSharePercent";
            this.txtSharePercent.Size = new System.Drawing.Size(27, 28);
            this.txtSharePercent.TabIndex = 83;
            // 
            // txtDriverName
            // 
            this.txtDriverName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDriverName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtDriverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDriverName.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDriverName.Location = new System.Drawing.Point(303, 557);
            this.txtDriverName.MaxLength = 75;
            this.txtDriverName.Multiline = true;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(163, 28);
            this.txtDriverName.TabIndex = 84;
            // 
            // comboboxCarModel
            // 
            this.comboboxCarModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxCarModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxCarModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.comboboxCarModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxCarModel.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboboxCarModel.FormattingEnabled = true;
            this.comboboxCarModel.Location = new System.Drawing.Point(576, 559);
            this.comboboxCarModel.MaxLength = 75;
            this.comboboxCarModel.Name = "comboboxCarModel";
            this.comboboxCarModel.Size = new System.Drawing.Size(165, 30);
            this.comboboxCarModel.Sorted = true;
            this.comboboxCarModel.TabIndex = 86;
            // 
            // comboboxCarColor
            // 
            this.comboboxCarColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxCarColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxCarColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.comboboxCarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxCarColor.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboboxCarColor.FormattingEnabled = true;
            this.comboboxCarColor.Location = new System.Drawing.Point(577, 612);
            this.comboboxCarColor.MaxLength = 75;
            this.comboboxCarColor.Name = "comboboxCarColor";
            this.comboboxCarColor.Size = new System.Drawing.Size(165, 30);
            this.comboboxCarColor.Sorted = true;
            this.comboboxCarColor.TabIndex = 87;
            // 
            // txtDriverPhone
            // 
            this.txtDriverPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDriverPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtDriverPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDriverPhone.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDriverPhone.Location = new System.Drawing.Point(303, 612);
            this.txtDriverPhone.MaxLength = 75;
            this.txtDriverPhone.Multiline = true;
            this.txtDriverPhone.Name = "txtDriverPhone";
            this.txtDriverPhone.Size = new System.Drawing.Size(163, 28);
            this.txtDriverPhone.TabIndex = 88;
            // 
            // txtLicencePlate4
            // 
            this.txtLicencePlate4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.txtLicencePlate4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicencePlate4.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLicencePlate4.Location = new System.Drawing.Point(603, 666);
            this.txtLicencePlate4.MaxLength = 2;
            this.txtLicencePlate4.Multiline = true;
            this.txtLicencePlate4.Name = "txtLicencePlate4";
            this.txtLicencePlate4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLicencePlate4.Size = new System.Drawing.Size(27, 27);
            this.txtLicencePlate4.TabIndex = 89;
            this.txtLicencePlate4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicencePlate1
            // 
            this.txtLicencePlate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.txtLicencePlate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicencePlate1.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLicencePlate1.Location = new System.Drawing.Point(705, 666);
            this.txtLicencePlate1.MaxLength = 2;
            this.txtLicencePlate1.Multiline = true;
            this.txtLicencePlate1.Name = "txtLicencePlate1";
            this.txtLicencePlate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLicencePlate1.Size = new System.Drawing.Size(27, 27);
            this.txtLicencePlate1.TabIndex = 90;
            this.txtLicencePlate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicencePlate3
            // 
            this.txtLicencePlate3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.txtLicencePlate3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicencePlate3.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLicencePlate3.Location = new System.Drawing.Point(636, 666);
            this.txtLicencePlate3.MaxLength = 3;
            this.txtLicencePlate3.Multiline = true;
            this.txtLicencePlate3.Name = "txtLicencePlate3";
            this.txtLicencePlate3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLicencePlate3.Size = new System.Drawing.Size(36, 27);
            this.txtLicencePlate3.TabIndex = 91;
            this.txtLicencePlate3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicencePlate2
            // 
            this.txtLicencePlate2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLicencePlate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.txtLicencePlate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicencePlate2.Font = new System.Drawing.Font("IRANYekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLicencePlate2.Location = new System.Drawing.Point(676, 666);
            this.txtLicencePlate2.MaxLength = 1;
            this.txtLicencePlate2.Multiline = true;
            this.txtLicencePlate2.Name = "txtLicencePlate2";
            this.txtLicencePlate2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLicencePlate2.Size = new System.Drawing.Size(24, 27);
            this.txtLicencePlate2.TabIndex = 92;
            this.txtLicencePlate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSave.Location = new System.Drawing.Point(997, 666);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 30);
            this.btnSave.TabIndex = 94;
            this.btnSave.UseVisualStyleBackColor = false;
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
            this.btnCancel.Location = new System.Drawing.Point(844, 665);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 30);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // CarPhoto
            // 
            this.CarPhoto.Image = ((System.Drawing.Image)(resources.GetObject("CarPhoto.Image")));
            this.CarPhoto.Location = new System.Drawing.Point(940, 559);
            this.CarPhoto.Name = "CarPhoto";
            this.CarPhoto.Size = new System.Drawing.Size(253, 77);
            this.CarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarPhoto.TabIndex = 95;
            this.CarPhoto.TabStop = false;
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.CarPhoto);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLicencePlate2);
            this.Controls.Add(this.txtLicencePlate3);
            this.Controls.Add(this.txtLicencePlate1);
            this.Controls.Add(this.txtLicencePlate4);
            this.Controls.Add(this.txtDriverPhone);
            this.Controls.Add(this.comboboxCarColor);
            this.Controls.Add(this.comboboxCarModel);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.txtSharePercent);
            this.Controls.Add(this.lblDateJoined);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdbDriver);
            this.Controls.Add(this.rdbDateJoined);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDrivers";
            this.ShowIcon = false;
            this.Text = "رانندگان";
            this.Controls.SetChildIndex(this.btnDashboard, 0);
            this.Controls.SetChildIndex(this.btnDrivers, 0);
            this.Controls.SetChildIndex(this.btnServices, 0);
            this.Controls.SetChildIndex(this.btnPaths, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.rdbDateJoined, 0);
            this.Controls.SetChildIndex(this.rdbDriver, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.lblDateJoined, 0);
            this.Controls.SetChildIndex(this.txtSharePercent, 0);
            this.Controls.SetChildIndex(this.txtDriverName, 0);
            this.Controls.SetChildIndex(this.comboboxCarModel, 0);
            this.Controls.SetChildIndex(this.comboboxCarColor, 0);
            this.Controls.SetChildIndex(this.txtDriverPhone, 0);
            this.Controls.SetChildIndex(this.txtLicencePlate4, 0);
            this.Controls.SetChildIndex(this.txtLicencePlate1, 0);
            this.Controls.SetChildIndex(this.txtLicencePlate3, 0);
            this.Controls.SetChildIndex(this.txtLicencePlate2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.CarPhoto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdbDriver;
        private System.Windows.Forms.RadioButton rdbDateJoined;
        public Utility.SizableTextBox txtSearch;
        public System.Windows.Forms.Label lblDateJoined;
        public Utility.NumericTextBox txtSharePercent;
        public Utility.SizableTextBox txtDriverName;
        private System.Windows.Forms.ComboBox comboboxCarModel;
        private System.Windows.Forms.ComboBox comboboxCarColor;
        public Utility.SizableTextBox txtDriverPhone;
        public Utility.NumericTextBox txtLicencePlate4;
        public Utility.NumericTextBox txtLicencePlate1;
        public Utility.NumericTextBox txtLicencePlate3;
        public Utility.SizableTextBox txtLicencePlate2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox CarPhoto;
    }
}