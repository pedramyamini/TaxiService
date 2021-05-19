
using BaseFormLibrary;
using System.Windows.Forms;

namespace WND.Forms
{
    partial class frmReporting : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporting));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReportThumbnail = new System.Windows.Forms.PictureBox();
            this.btnCustomersThumbnail = new System.Windows.Forms.PictureBox();
            this.btnPathsThumbnail = new System.Windows.Forms.PictureBox();
            this.btnServicesThumbnail = new System.Windows.Forms.PictureBox();
            this.btnDriversThumbnail = new System.Windows.Forms.PictureBox();
            this.btnSecretaryThumbnail = new System.Windows.Forms.PictureBox();
            this.txtCustomerName = new Utility.SizableTextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.comboboxPaths = new System.Windows.Forms.ComboBox();
            this.comboboxDrivers = new System.Windows.Forms.ComboBox();
            this.checkboxIsPaid = new System.Windows.Forms.CheckBox();
            this.txtDestinationInDetail = new Utility.SizableTextBox();
            this.txtOriginInDetail = new Utility.SizableTextBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDelay = new Utility.NumericTextBox();
            this.lblLicencePlate3 = new System.Windows.Forms.Label();
            this.lblLicencePlate4 = new System.Windows.Forms.Label();
            this.lblLicencePlate2 = new System.Windows.Forms.Label();
            this.lblLicencePlate1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomersThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPathsThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServicesThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDriversThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSecretaryThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 486);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1123, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnReportThumbnail
            // 
            this.btnReportThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("btnReportThumbnail.Image")));
            this.btnReportThumbnail.Location = new System.Drawing.Point(202, 162);
            this.btnReportThumbnail.Name = "btnReportThumbnail";
            this.btnReportThumbnail.Size = new System.Drawing.Size(180, 139);
            this.btnReportThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReportThumbnail.TabIndex = 17;
            this.btnReportThumbnail.TabStop = false;
            this.btnReportThumbnail.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnCustomersThumbnail
            // 
            this.btnCustomersThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomersThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomersThumbnail.Image")));
            this.btnCustomersThumbnail.Location = new System.Drawing.Point(390, 162);
            this.btnCustomersThumbnail.Name = "btnCustomersThumbnail";
            this.btnCustomersThumbnail.Size = new System.Drawing.Size(180, 139);
            this.btnCustomersThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCustomersThumbnail.TabIndex = 18;
            this.btnCustomersThumbnail.TabStop = false;
            this.btnCustomersThumbnail.Click += new System.EventHandler(this.btnCustomersThumbnail_Click);
            // 
            // btnPathsThumbnail
            // 
            this.btnPathsThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathsThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("btnPathsThumbnail.Image")));
            this.btnPathsThumbnail.Location = new System.Drawing.Point(578, 162);
            this.btnPathsThumbnail.Name = "btnPathsThumbnail";
            this.btnPathsThumbnail.Size = new System.Drawing.Size(180, 139);
            this.btnPathsThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPathsThumbnail.TabIndex = 19;
            this.btnPathsThumbnail.TabStop = false;
            this.btnPathsThumbnail.Click += new System.EventHandler(this.btnPathsThumbnail_Click);
            // 
            // btnServicesThumbnail
            // 
            this.btnServicesThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicesThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("btnServicesThumbnail.Image")));
            this.btnServicesThumbnail.Location = new System.Drawing.Point(766, 162);
            this.btnServicesThumbnail.Name = "btnServicesThumbnail";
            this.btnServicesThumbnail.Size = new System.Drawing.Size(180, 139);
            this.btnServicesThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnServicesThumbnail.TabIndex = 20;
            this.btnServicesThumbnail.TabStop = false;
            this.btnServicesThumbnail.Click += new System.EventHandler(this.btnServicesThumbnail_Click);
            // 
            // btnDriversThumbnail
            // 
            this.btnDriversThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriversThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("btnDriversThumbnail.Image")));
            this.btnDriversThumbnail.Location = new System.Drawing.Point(954, 162);
            this.btnDriversThumbnail.Name = "btnDriversThumbnail";
            this.btnDriversThumbnail.Size = new System.Drawing.Size(180, 139);
            this.btnDriversThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDriversThumbnail.TabIndex = 21;
            this.btnDriversThumbnail.TabStop = false;
            this.btnDriversThumbnail.Click += new System.EventHandler(this.btnDriversThumbnail_Click);
            // 
            // btnSecretaryThumbnail
            // 
            this.btnSecretaryThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecretaryThumbnail.Image = ((System.Drawing.Image)(resources.GetObject("btnSecretaryThumbnail.Image")));
            this.btnSecretaryThumbnail.Location = new System.Drawing.Point(1142, 162);
            this.btnSecretaryThumbnail.Name = "btnSecretaryThumbnail";
            this.btnSecretaryThumbnail.Size = new System.Drawing.Size(180, 139);
            this.btnSecretaryThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSecretaryThumbnail.TabIndex = 22;
            this.btnSecretaryThumbnail.TabStop = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCustomerName.Location = new System.Drawing.Point(312, 567);
            this.txtCustomerName.MaxLength = 75;
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(163, 28);
            this.txtCustomerName.TabIndex = 23;
            // 
            // lblCost
            // 
            this.lblCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblCost.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCost.Location = new System.Drawing.Point(578, 675);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(91, 28);
            this.lblCost.TabIndex = 24;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblCustomerPhone.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(312, 622);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(163, 28);
            this.lblCustomerPhone.TabIndex = 25;
            // 
            // comboboxPaths
            // 
            this.comboboxPaths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxPaths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.comboboxPaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxPaths.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboboxPaths.FormattingEnabled = true;
            this.comboboxPaths.Location = new System.Drawing.Point(578, 566);
            this.comboboxPaths.MaxLength = 75;
            this.comboboxPaths.Name = "comboboxPaths";
            this.comboboxPaths.Size = new System.Drawing.Size(165, 24);
            this.comboboxPaths.Sorted = true;
            this.comboboxPaths.TabIndex = 26;
            // 
            // comboboxDrivers
            // 
            this.comboboxDrivers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxDrivers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.comboboxDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxDrivers.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboboxDrivers.FormattingEnabled = true;
            this.comboboxDrivers.Location = new System.Drawing.Point(578, 618);
            this.comboboxDrivers.MaxLength = 75;
            this.comboboxDrivers.Name = "comboboxDrivers";
            this.comboboxDrivers.Size = new System.Drawing.Size(165, 24);
            this.comboboxDrivers.Sorted = true;
            this.comboboxDrivers.TabIndex = 27;
            // 
            // checkboxIsPaid
            // 
            this.checkboxIsPaid.Font = new System.Drawing.Font("IRANYekan", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxIsPaid.Location = new System.Drawing.Point(712, 688);
            this.checkboxIsPaid.Name = "checkboxIsPaid";
            this.checkboxIsPaid.Size = new System.Drawing.Size(14, 14);
            this.checkboxIsPaid.TabIndex = 28;
            this.checkboxIsPaid.UseVisualStyleBackColor = true;
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
            this.txtDestinationInDetail.TabIndex = 29;
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
            this.txtOriginInDetail.TabIndex = 30;
            // 
            // lblCar
            // 
            this.lblCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblCar.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCar.Location = new System.Drawing.Point(889, 618);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(265, 28);
            this.lblCar.TabIndex = 31;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblDate.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDate.Location = new System.Drawing.Point(312, 674);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 28);
            this.lblDate.TabIndex = 32;
            // 
            // txtDelay
            // 
            this.txtDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelay.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDelay.Location = new System.Drawing.Point(448, 675);
            this.txtDelay.MaxLength = 3;
            this.txtDelay.Multiline = true;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(27, 28);
            this.txtDelay.TabIndex = 33;
            // 
            // lblLicencePlate3
            // 
            this.lblLicencePlate3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(81)))));
            this.lblLicencePlate3.Font = new System.Drawing.Font("IRANYekan", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencePlate3.ForeColor = System.Drawing.Color.Black;
            this.lblLicencePlate3.Location = new System.Drawing.Point(1187, 622);
            this.lblLicencePlate3.Name = "lblLicencePlate3";
            this.lblLicencePlate3.Size = new System.Drawing.Size(28, 22);
            this.lblLicencePlate3.TabIndex = 35;
            this.lblLicencePlate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicencePlate4
            // 
            this.lblLicencePlate4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(81)))));
            this.lblLicencePlate4.Font = new System.Drawing.Font("IRANYekan", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencePlate4.ForeColor = System.Drawing.Color.Black;
            this.lblLicencePlate4.Location = new System.Drawing.Point(1160, 622);
            this.lblLicencePlate4.Name = "lblLicencePlate4";
            this.lblLicencePlate4.Size = new System.Drawing.Size(21, 22);
            this.lblLicencePlate4.TabIndex = 34;
            this.lblLicencePlate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicencePlate2
            // 
            this.lblLicencePlate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(81)))));
            this.lblLicencePlate2.Font = new System.Drawing.Font("IRANYekan", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicencePlate2.ForeColor = System.Drawing.Color.Black;
            this.lblLicencePlate2.Location = new System.Drawing.Point(1219, 622);
            this.lblLicencePlate2.Name = "lblLicencePlate2";
            this.lblLicencePlate2.Size = new System.Drawing.Size(20, 22);
            this.lblLicencePlate2.TabIndex = 36;
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
            this.lblLicencePlate1.TabIndex = 37;
            this.lblLicencePlate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.TabIndex = 55;
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
            this.btnCancel.Location = new System.Drawing.Point(839, 672);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 30);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLicencePlate1);
            this.Controls.Add(this.lblLicencePlate2);
            this.Controls.Add(this.lblLicencePlate3);
            this.Controls.Add(this.lblLicencePlate4);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.txtOriginInDetail);
            this.Controls.Add(this.txtDestinationInDetail);
            this.Controls.Add(this.checkboxIsPaid);
            this.Controls.Add(this.comboboxDrivers);
            this.Controls.Add(this.comboboxPaths);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnSecretaryThumbnail);
            this.Controls.Add(this.btnDriversThumbnail);
            this.Controls.Add(this.btnServicesThumbnail);
            this.Controls.Add(this.btnPathsThumbnail);
            this.Controls.Add(this.btnCustomersThumbnail);
            this.Controls.Add(this.btnReportThumbnail);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmReporting";
            this.ShowIcon = false;
            this.Text = "گزارش‌گیری";
            this.Controls.SetChildIndex(this.btnDashboard, 0);
            this.Controls.SetChildIndex(this.btnDrivers, 0);
            this.Controls.SetChildIndex(this.btnServices, 0);
            this.Controls.SetChildIndex(this.btnPaths, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.btnReportThumbnail, 0);
            this.Controls.SetChildIndex(this.btnCustomersThumbnail, 0);
            this.Controls.SetChildIndex(this.btnPathsThumbnail, 0);
            this.Controls.SetChildIndex(this.btnServicesThumbnail, 0);
            this.Controls.SetChildIndex(this.btnDriversThumbnail, 0);
            this.Controls.SetChildIndex(this.btnSecretaryThumbnail, 0);
            this.Controls.SetChildIndex(this.txtCustomerName, 0);
            this.Controls.SetChildIndex(this.lblCost, 0);
            this.Controls.SetChildIndex(this.lblCustomerPhone, 0);
            this.Controls.SetChildIndex(this.comboboxPaths, 0);
            this.Controls.SetChildIndex(this.comboboxDrivers, 0);
            this.Controls.SetChildIndex(this.checkboxIsPaid, 0);
            this.Controls.SetChildIndex(this.txtDestinationInDetail, 0);
            this.Controls.SetChildIndex(this.txtOriginInDetail, 0);
            this.Controls.SetChildIndex(this.lblCar, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.txtDelay, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate4, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate3, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate2, 0);
            this.Controls.SetChildIndex(this.lblLicencePlate1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomersThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPathsThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServicesThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDriversThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSecretaryThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox btnReportThumbnail;
        private PictureBox btnCustomersThumbnail;
        private PictureBox btnPathsThumbnail;
        private PictureBox btnServicesThumbnail;
        private PictureBox btnDriversThumbnail;
        private PictureBox btnSecretaryThumbnail;
        public Utility.SizableTextBox txtCustomerName;
        public Label lblCost;
        public Label lblCustomerPhone;
        private ComboBox comboboxPaths;
        private ComboBox comboboxDrivers;
        private CheckBox checkboxIsPaid;
        public Utility.SizableTextBox txtDestinationInDetail;
        public Utility.SizableTextBox txtOriginInDetail;
        public Label lblCar;
        public Label lblDate;
        public Utility.NumericTextBox txtDelay;
        private Label lblLicencePlate4;
        private Label lblLicencePlate3;
        private Label lblLicencePlate2;
        private Label lblLicencePlate1;
        private Button btnSave;
        private Button btnCancel;
    }
}