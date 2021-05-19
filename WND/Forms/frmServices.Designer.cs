
namespace WND.Forms
{
    partial class frmServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServices));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkboxIsPaid = new System.Windows.Forms.CheckBox();
            this.txtCustomerName = new Utility.SizableTextBox();
            this.comboboxPaths = new System.Windows.Forms.ComboBox();
            this.comboboxDrivers = new System.Windows.Forms.ComboBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDelay = new Utility.NumericTextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtOriginInDetail = new Utility.SizableTextBox();
            this.txtDestinationInDetail = new Utility.SizableTextBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblLicencePlate4 = new System.Windows.Forms.Label();
            this.lblLicencePlate3 = new System.Windows.Forms.Label();
            this.lblLicencePlate2 = new System.Windows.Forms.Label();
            this.lblLicencePlate1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rdbCustomer = new System.Windows.Forms.RadioButton();
            this.rdbDriver = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new Utility.SizableTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 486);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1123, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
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
            this.btnCancel.Location = new System.Drawing.Point(839, 672);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 30);
            this.btnCancel.TabIndex = 57;
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
            this.btnSave.Location = new System.Drawing.Point(992, 673);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 30);
            this.btnSave.TabIndex = 58;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // checkboxIsPaid
            // 
            this.checkboxIsPaid.Font = new System.Drawing.Font("IRANYekan", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxIsPaid.Location = new System.Drawing.Point(712, 688);
            this.checkboxIsPaid.Name = "checkboxIsPaid";
            this.checkboxIsPaid.Size = new System.Drawing.Size(14, 14);
            this.checkboxIsPaid.TabIndex = 59;
            this.checkboxIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCustomerName.Location = new System.Drawing.Point(312, 567);
            this.txtCustomerName.MaxLength = 75;
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(163, 28);
            this.txtCustomerName.TabIndex = 60;
            // 
            // comboboxPaths
            // 
            this.comboboxPaths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxPaths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.comboboxPaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxPaths.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboboxPaths.FormattingEnabled = true;
            this.comboboxPaths.Location = new System.Drawing.Point(578, 566);
            this.comboboxPaths.MaxLength = 75;
            this.comboboxPaths.Name = "comboboxPaths";
            this.comboboxPaths.Size = new System.Drawing.Size(165, 30);
            this.comboboxPaths.Sorted = true;
            this.comboboxPaths.TabIndex = 61;
            // 
            // comboboxDrivers
            // 
            this.comboboxDrivers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxDrivers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.comboboxDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxDrivers.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboboxDrivers.FormattingEnabled = true;
            this.comboboxDrivers.Location = new System.Drawing.Point(578, 618);
            this.comboboxDrivers.MaxLength = 75;
            this.comboboxDrivers.Name = "comboboxDrivers";
            this.comboboxDrivers.Size = new System.Drawing.Size(165, 30);
            this.comboboxDrivers.Sorted = true;
            this.comboboxDrivers.TabIndex = 62;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblCustomerPhone.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(312, 622);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(163, 28);
            this.lblCustomerPhone.TabIndex = 63;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblDate.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(312, 674);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 28);
            this.lblDate.TabIndex = 64;
            // 
            // txtDelay
            // 
            this.txtDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelay.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDelay.Location = new System.Drawing.Point(448, 675);
            this.txtDelay.MaxLength = 3;
            this.txtDelay.Multiline = true;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(27, 28);
            this.txtDelay.TabIndex = 65;
            // 
            // lblCost
            // 
            this.lblCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblCost.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCost.Location = new System.Drawing.Point(578, 675);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(91, 28);
            this.lblCost.TabIndex = 66;
            // 
            // txtOriginInDetail
            // 
            this.txtOriginInDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtOriginInDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOriginInDetail.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtOriginInDetail.Location = new System.Drawing.Point(866, 568);
            this.txtOriginInDetail.MaxLength = 50;
            this.txtOriginInDetail.Multiline = true;
            this.txtOriginInDetail.Name = "txtOriginInDetail";
            this.txtOriginInDetail.Size = new System.Drawing.Size(171, 28);
            this.txtOriginInDetail.TabIndex = 67;
            // 
            // txtDestinationInDetail
            // 
            this.txtDestinationInDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtDestinationInDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestinationInDetail.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDestinationInDetail.Location = new System.Drawing.Point(1102, 568);
            this.txtDestinationInDetail.MaxLength = 50;
            this.txtDestinationInDetail.Multiline = true;
            this.txtDestinationInDetail.Name = "txtDestinationInDetail";
            this.txtDestinationInDetail.Size = new System.Drawing.Size(175, 28);
            this.txtDestinationInDetail.TabIndex = 68;
            // 
            // lblCar
            // 
            this.lblCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblCar.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCar.Location = new System.Drawing.Point(889, 618);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(265, 28);
            this.lblCar.TabIndex = 69;
            // 
            // lblLicencePlate4
            // 
            this.lblLicencePlate4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(81)))));
            this.lblLicencePlate4.Font = new System.Drawing.Font("IRANYekan", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencePlate4.ForeColor = System.Drawing.Color.Black;
            this.lblLicencePlate4.Location = new System.Drawing.Point(1160, 622);
            this.lblLicencePlate4.Name = "lblLicencePlate4";
            this.lblLicencePlate4.Size = new System.Drawing.Size(21, 22);
            this.lblLicencePlate4.TabIndex = 70;
            this.lblLicencePlate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicencePlate3
            // 
            this.lblLicencePlate3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(81)))));
            this.lblLicencePlate3.Font = new System.Drawing.Font("IRANYekan", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencePlate3.ForeColor = System.Drawing.Color.Black;
            this.lblLicencePlate3.Location = new System.Drawing.Point(1187, 622);
            this.lblLicencePlate3.Name = "lblLicencePlate3";
            this.lblLicencePlate3.Size = new System.Drawing.Size(28, 22);
            this.lblLicencePlate3.TabIndex = 71;
            this.lblLicencePlate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicencePlate2
            // 
            this.lblLicencePlate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(81)))));
            this.lblLicencePlate2.Font = new System.Drawing.Font("IRANYekan", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencePlate2.ForeColor = System.Drawing.Color.Black;
            this.lblLicencePlate2.Location = new System.Drawing.Point(1219, 622);
            this.lblLicencePlate2.Name = "lblLicencePlate2";
            this.lblLicencePlate2.Size = new System.Drawing.Size(20, 22);
            this.lblLicencePlate2.TabIndex = 72;
            this.lblLicencePlate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicencePlate1
            // 
            this.lblLicencePlate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(81)))));
            this.lblLicencePlate1.Font = new System.Drawing.Font("IRANYekan", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencePlate1.ForeColor = System.Drawing.Color.Black;
            this.lblLicencePlate1.Location = new System.Drawing.Point(1242, 622);
            this.lblLicencePlate1.Name = "lblLicencePlate1";
            this.lblLicencePlate1.Size = new System.Drawing.Size(22, 22);
            this.lblLicencePlate1.TabIndex = 73;
            this.lblLicencePlate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(212, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1098, 373);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // rdbCustomer
            // 
            this.rdbCustomer.AutoSize = true;
            this.rdbCustomer.BackColor = System.Drawing.Color.White;
            this.rdbCustomer.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustomer.Location = new System.Drawing.Point(672, 161);
            this.rdbCustomer.Name = "rdbCustomer";
            this.rdbCustomer.Size = new System.Drawing.Size(71, 21);
            this.rdbCustomer.TabIndex = 75;
            this.rdbCustomer.TabStop = true;
            this.rdbCustomer.Text = "نام مشتری";
            this.rdbCustomer.UseVisualStyleBackColor = false;
            // 
            // rdbDriver
            // 
            this.rdbDriver.AutoSize = true;
            this.rdbDriver.BackColor = System.Drawing.Color.White;
            this.rdbDriver.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDriver.Location = new System.Drawing.Point(750, 161);
            this.rdbDriver.Name = "rdbDriver";
            this.rdbDriver.Size = new System.Drawing.Size(65, 21);
            this.rdbDriver.TabIndex = 76;
            this.rdbDriver.TabStop = true;
            this.rdbDriver.Text = "نام راننده";
            this.rdbDriver.UseVisualStyleBackColor = false;
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
            this.btnSearch.Location = new System.Drawing.Point(1014, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 25);
            this.btnSearch.TabIndex = 77;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("IRANYekan", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(852, 161);
            this.txtSearch.MaxLength = 75;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 25);
            this.txtSearch.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(178)))));
            this.label1.Font = new System.Drawing.Font("IRANYekan", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(266, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 79;
            this.label1.Text = "مشخصات سرویس";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdbDriver);
            this.Controls.Add(this.rdbCustomer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblLicencePlate1);
            this.Controls.Add(this.lblLicencePlate2);
            this.Controls.Add(this.lblLicencePlate3);
            this.Controls.Add(this.lblLicencePlate4);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.txtDestinationInDetail);
            this.Controls.Add(this.txtOriginInDetail);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.comboboxDrivers);
            this.Controls.Add(this.comboboxPaths);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.checkboxIsPaid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmServices";
            this.ShowIcon = false;
            this.Text = "سرویس‌ها";
            this.Controls.SetChildIndex(this.btnDashboard, 0);
            this.Controls.SetChildIndex(this.btnDrivers, 0);
            this.Controls.SetChildIndex(this.btnServices, 0);
            this.Controls.SetChildIndex(this.btnPaths, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.checkboxIsPaid, 0);
            this.Controls.SetChildIndex(this.txtCustomerName, 0);
            this.Controls.SetChildIndex(this.comboboxPaths, 0);
            this.Controls.SetChildIndex(this.comboboxDrivers, 0);
            this.Controls.SetChildIndex(this.lblCustomerPhone, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.txtDelay, 0);
            this.Controls.SetChildIndex(this.lblCost, 0);
            this.Controls.SetChildIndex(this.txtOriginInDetail, 0);
            this.Controls.SetChildIndex(this.txtDestinationInDetail, 0);
            this.Controls.SetChildIndex(this.lblCar, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate4, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate3, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate2, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate1, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.rdbCustomer, 0);
            this.Controls.SetChildIndex(this.rdbDriver, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkboxIsPaid;
        public Utility.SizableTextBox txtCustomerName;
        private System.Windows.Forms.ComboBox comboboxPaths;
        private System.Windows.Forms.ComboBox comboboxDrivers;
        public System.Windows.Forms.Label lblCustomerPhone;
        public System.Windows.Forms.Label lblDate;
        public Utility.NumericTextBox txtDelay;
        public System.Windows.Forms.Label lblCost;
        public Utility.SizableTextBox txtOriginInDetail;
        public Utility.SizableTextBox txtDestinationInDetail;
        public System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblLicencePlate4;
        private System.Windows.Forms.Label lblLicencePlate3;
        private System.Windows.Forms.Label lblLicencePlate2;
        private System.Windows.Forms.Label lblLicencePlate1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rdbCustomer;
        private System.Windows.Forms.RadioButton rdbDriver;
        private System.Windows.Forms.Button btnSearch;
        public Utility.SizableTextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}