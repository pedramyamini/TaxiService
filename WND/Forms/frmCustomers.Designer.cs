
using BaseFormLibrary;
using System.Windows.Forms;

namespace WND.Forms
{
    partial class frmCustomers : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtCustomerFullName = new Utility.SizableTextBox();
            this.txtCustomerPhone = new Utility.NumericTextBox();
            this.txtCustomerAddress = new Utility.SizableTextBox();
            this.txtSearch = new Utility.SizableTextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalServices = new System.Windows.Forms.Label();
            this.lblLastCost = new System.Windows.Forms.Label();
            this.lblLastOrigin = new System.Windows.Forms.Label();
            this.lblLastDestination = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gridCustomers = new Utility.RadGridViewCustom();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(183, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1201, 564);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.btnSave.Location = new System.Drawing.Point(390, 624);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 30);
            this.btnSave.TabIndex = 38;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(208, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(462, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
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
            this.btnSearch.Location = new System.Drawing.Point(611, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 33);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(208, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(213, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // txtCustomerFullName
            // 
            this.txtCustomerFullName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomerFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtCustomerFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerFullName.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCustomerFullName.Location = new System.Drawing.Point(282, 535);
            this.txtCustomerFullName.MaxLength = 75;
            this.txtCustomerFullName.Multiline = true;
            this.txtCustomerFullName.Name = "txtCustomerFullName";
            this.txtCustomerFullName.Size = new System.Drawing.Size(167, 28);
            this.txtCustomerFullName.TabIndex = 42;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerPhone.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(507, 535);
            this.txtCustomerPhone.MaxLength = 11;
            this.txtCustomerPhone.Multiline = true;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(163, 28);
            this.txtCustomerPhone.TabIndex = 43;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerAddress.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(282, 580);
            this.txtCustomerAddress.MaxLength = 75;
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(388, 28);
            this.txtCustomerAddress.TabIndex = 44;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(223, 138);
            this.txtSearch.MaxLength = 75;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(384, 33);
            this.txtSearch.TabIndex = 45;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblTotalCost.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalCost.Location = new System.Drawing.Point(904, 288);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(89, 24);
            this.lblTotalCost.TabIndex = 47;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalServices
            // 
            this.lblTotalServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblTotalServices.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalServices.Location = new System.Drawing.Point(1033, 287);
            this.lblTotalServices.Name = "lblTotalServices";
            this.lblTotalServices.Size = new System.Drawing.Size(89, 24);
            this.lblTotalServices.TabIndex = 48;
            this.lblTotalServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastCost
            // 
            this.lblLastCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(130)))));
            this.lblLastCost.Font = new System.Drawing.Font("IRANYekan", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastCost.ForeColor = System.Drawing.Color.Black;
            this.lblLastCost.Image = ((System.Drawing.Image)(resources.GetObject("lblLastCost.Image")));
            this.lblLastCost.Location = new System.Drawing.Point(752, 474);
            this.lblLastCost.Name = "lblLastCost";
            this.lblLastCost.Size = new System.Drawing.Size(78, 52);
            this.lblLastCost.TabIndex = 49;
            this.lblLastCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastOrigin
            // 
            this.lblLastOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblLastOrigin.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastOrigin.Location = new System.Drawing.Point(827, 584);
            this.lblLastOrigin.Name = "lblLastOrigin";
            this.lblLastOrigin.Size = new System.Drawing.Size(89, 20);
            this.lblLastOrigin.TabIndex = 50;
            this.lblLastOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastDestination
            // 
            this.lblLastDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.lblLastDestination.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastDestination.Location = new System.Drawing.Point(827, 604);
            this.lblLastDestination.Name = "lblLastDestination";
            this.lblLastDestination.Size = new System.Drawing.Size(89, 20);
            this.lblLastDestination.TabIndex = 51;
            this.lblLastDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCancel.Location = new System.Drawing.Point(252, 624);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 30);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrevious.Location = new System.Drawing.Point(1250, 635);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(31, 30);
            this.btnPrevious.TabIndex = 53;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNext.Location = new System.Drawing.Point(1212, 635);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 30);
            this.btnNext.TabIndex = 54;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl1.Font = new System.Drawing.Font("IRANYekan", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl1.Location = new System.Drawing.Point(872, 203);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 47);
            this.lbl1.TabIndex = 55;
            this.lbl1.Text = "مسافرت‌های";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridCustomers
            // 
            this.gridCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridCustomers.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCustomers.Location = new System.Drawing.Point(212, 221);
            // 
            // 
            // 
            this.gridCustomers.MasterTemplate.AllowAddNewRow = false;
            this.gridCustomers.MasterTemplate.AllowColumnReorder = false;
            this.gridCustomers.MasterTemplate.AllowDragToGroup = false;
            this.gridCustomers.MasterTemplate.AllowEditRow = false;
            this.gridCustomers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCommandColumn3.AllowHide = false;
            gridViewCommandColumn3.HeaderText = "ویرایش";
            gridViewCommandColumn3.Image = global::WND.Properties.Resources.Icon_feather_edit;
            gridViewCommandColumn3.MaxWidth = 60;
            gridViewCommandColumn3.Name = "GridEditBtn";
            gridViewCommandColumn3.Width = 60;
            gridViewCommandColumn4.AllowHide = false;
            gridViewCommandColumn4.HeaderText = "حذف";
            gridViewCommandColumn4.Image = global::WND.Properties.Resources.Icon_material_delete_forever;
            gridViewCommandColumn4.MaxWidth = 50;
            gridViewCommandColumn4.Name = "GridDeleteBtn";
            this.gridCustomers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCommandColumn3,
            gridViewCommandColumn4});
            this.gridCustomers.MasterTemplate.EnableGrouping = false;
            this.gridCustomers.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.None;
            this.gridCustomers.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.ReadOnly = true;
            // 
            // 
            // 
            this.gridCustomers.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.gridCustomers.Size = new System.Drawing.Size(488, 271);
            this.gridCustomers.TabIndex = 62;
            this.gridCustomers.ThemeName = "Material";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblCustomerName.Font = new System.Drawing.Font("IRANYekan", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCustomerName.Location = new System.Drawing.Point(973, 203);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(212, 47);
            this.lblCustomerName.TabIndex = 63;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCustomers
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLastDestination);
            this.Controls.Add(this.lblLastOrigin);
            this.Controls.Add(this.lblLastCost);
            this.Controls.Add(this.lblTotalServices);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerFullName);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCustomers";
            this.ShowIcon = false;
            this.Text = "مسافران";
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.txtCustomerFullName, 0);
            this.Controls.SetChildIndex(this.txtCustomerPhone, 0);
            this.Controls.SetChildIndex(this.txtCustomerAddress, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.lblTotalCost, 0);
            this.Controls.SetChildIndex(this.lblTotalServices, 0);
            this.Controls.SetChildIndex(this.lblLastCost, 0);
            this.Controls.SetChildIndex(this.lblLastOrigin, 0);
            this.Controls.SetChildIndex(this.lblLastDestination, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnPrevious, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.btnDashboard, 0);
            this.Controls.SetChildIndex(this.btnDrivers, 0);
            this.Controls.SetChildIndex(this.btnServices, 0);
            this.Controls.SetChildIndex(this.btnPaths, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.gridCustomers, 0);
            this.Controls.SetChildIndex(this.lblCustomerName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnSave;
        private PictureBox pictureBox3;
        private Button btnSearch;
        private PictureBox pictureBox4;
        public Utility.SizableTextBox txtCustomerFullName;
        public Utility.NumericTextBox txtCustomerPhone;
        public Utility.SizableTextBox txtCustomerAddress;
        public Utility.SizableTextBox txtSearch;
        public Label lblTotalCost;
        public Label lblTotalServices;
        private Label lblLastCost;
        public Label lblLastOrigin;
        public Label lblLastDestination;
        private Button btnCancel;
        private Button btnPrevious;
        private Button btnNext;
        public Label lbl1;
        private Utility.RadGridViewCustom gridCustomers;
        public Label lblCustomerName;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}