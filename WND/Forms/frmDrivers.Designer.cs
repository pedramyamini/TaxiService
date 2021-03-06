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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn17 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn18 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition9 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new Utility.SizableTextBox();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.txtSharePercent = new Utility.NumericTextBox();
            this.txtDriverName = new Utility.SizableTextBox();
            this.comboboxCarModel = new System.Windows.Forms.ComboBox();
            this.comboboxCarColor = new System.Windows.Forms.ComboBox();
            this.txtDriverPhone = new Utility.NumericTextBox();
            this.txtLicencePlate4 = new Utility.NumericTextBox();
            this.txtLicencePlate1 = new Utility.NumericTextBox();
            this.txtLicencePlate3 = new Utility.NumericTextBox();
            this.txtLicencePlate2 = new Utility.SizableTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.CarPhoto = new System.Windows.Forms.PictureBox();
            this.gridDrivers = new Utility.RadGridViewCustom();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            // 
            // btnDrivers
            // 
            this.btnDrivers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            // 
            // btnServices
            // 
            this.btnServices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            // 
            // btnPaths
            // 
            this.btnPaths.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnPaths.FlatAppearance.BorderSize = 0;
            this.btnPaths.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnPaths.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
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
            this.btnSearch.BackgroundImage = global::WND.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(957, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("IRANYekan", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(578, 152);
            this.txtSearch.MaxLength = 75;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(379, 25);
            this.txtSearch.TabIndex = 6;
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblDateJoined.Font = new System.Drawing.Font("IRANYekan", 6F);
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
            this.txtSharePercent.TabIndex = 11;
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
            this.txtDriverName.TabIndex = 9;
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
            this.comboboxCarModel.TabIndex = 12;
            this.comboboxCarModel.SelectedIndexChanged += new System.EventHandler(this.comboboxCarModel_SelectedIndexChanged);
            this.comboboxCarModel.TextUpdate += new System.EventHandler(this.comboboxCarModel_TextUpdate);
            this.comboboxCarModel.TextChanged += new System.EventHandler(this.comboboxCarModel_TextChanged);
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
            this.comboboxCarColor.TabIndex = 13;
            this.comboboxCarColor.SelectedIndexChanged += new System.EventHandler(this.comboboxCarColor_SelectedIndexChanged);
            this.comboboxCarColor.TextUpdate += new System.EventHandler(this.comboboxCarColor_TextUpdate);
            this.comboboxCarColor.TextChanged += new System.EventHandler(this.comboboxCarColor_TextChanged);
            // 
            // txtDriverPhone
            // 
            this.txtDriverPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDriverPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtDriverPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDriverPhone.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDriverPhone.Location = new System.Drawing.Point(303, 612);
            this.txtDriverPhone.MaxLength = 11;
            this.txtDriverPhone.Multiline = true;
            this.txtDriverPhone.Name = "txtDriverPhone";
            this.txtDriverPhone.Size = new System.Drawing.Size(163, 28);
            this.txtDriverPhone.TabIndex = 10;
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
            this.txtLicencePlate4.TabIndex = 17;
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
            this.txtLicencePlate1.TabIndex = 14;
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
            this.txtLicencePlate3.TabIndex = 16;
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
            this.txtLicencePlate2.TabIndex = 15;
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
            this.btnSave.TabIndex = 18;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CarPhoto
            // 
            this.CarPhoto.Image = global::WND.Properties.Resources.Unknown_Car;
            this.CarPhoto.Location = new System.Drawing.Point(940, 559);
            this.CarPhoto.Name = "CarPhoto";
            this.CarPhoto.Size = new System.Drawing.Size(253, 77);
            this.CarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarPhoto.TabIndex = 95;
            this.CarPhoto.TabStop = false;
            // 
            // gridDrivers
            // 
            this.gridDrivers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridDrivers.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDrivers.Location = new System.Drawing.Point(209, 188);
            // 
            // 
            // 
            this.gridDrivers.MasterTemplate.AllowAddNewRow = false;
            this.gridDrivers.MasterTemplate.AllowColumnReorder = false;
            this.gridDrivers.MasterTemplate.AllowDragToGroup = false;
            this.gridDrivers.MasterTemplate.AllowEditRow = false;
            this.gridDrivers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCommandColumn17.AllowHide = false;
            gridViewCommandColumn17.HeaderText = "ویرایش";
            gridViewCommandColumn17.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn17.Image")));
            gridViewCommandColumn17.MaxWidth = 60;
            gridViewCommandColumn17.Name = "GridEditBtn";
            gridViewCommandColumn17.Width = 60;
            gridViewCommandColumn18.AllowHide = false;
            gridViewCommandColumn18.HeaderText = "حذف";
            gridViewCommandColumn18.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn18.Image")));
            gridViewCommandColumn18.MaxWidth = 50;
            gridViewCommandColumn18.Name = "GridDeleteBtn";
            this.gridDrivers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCommandColumn17,
            gridViewCommandColumn18});
            this.gridDrivers.MasterTemplate.EnableGrouping = false;
            this.gridDrivers.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.None;
            this.gridDrivers.MasterTemplate.ViewDefinition = tableViewDefinition9;
            this.gridDrivers.Name = "gridDrivers";
            this.gridDrivers.ReadOnly = true;
            // 
            // 
            // 
            this.gridDrivers.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.gridDrivers.RootElement.ControlBounds = new System.Drawing.Rectangle(209, 188, 240, 150);
            this.gridDrivers.Size = new System.Drawing.Size(1102, 271);
            this.gridDrivers.TabIndex = 8;
            this.gridDrivers.ThemeName = "Material";
            // 
            // frmDrivers
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gridDrivers);
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
            this.Controls.SetChildIndex(this.gridDrivers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSearch;
        public Utility.SizableTextBox txtSearch;
        public System.Windows.Forms.Label lblDateJoined;
        public Utility.NumericTextBox txtSharePercent;
        public Utility.SizableTextBox txtDriverName;
        private System.Windows.Forms.ComboBox comboboxCarModel;
        private System.Windows.Forms.ComboBox comboboxCarColor;
        public Utility.NumericTextBox txtDriverPhone;
        public Utility.NumericTextBox txtLicencePlate4;
        public Utility.NumericTextBox txtLicencePlate1;
        public Utility.NumericTextBox txtLicencePlate3;
        public Utility.SizableTextBox txtLicencePlate2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox CarPhoto;
        private Utility.RadGridViewCustom gridDrivers;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}