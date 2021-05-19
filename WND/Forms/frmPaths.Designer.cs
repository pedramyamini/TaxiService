﻿
using Utility;

namespace WND.Forms
{
    partial class frmPaths
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaths));
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOrigin = new Utility.SizableTextBox();
            this.txtCost = new Utility.NumericTextBox();
            this.txtDestination = new Utility.SizableTextBox();
            this.txtSearch = new Utility.SizableTextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.gridPaths = new Utility.RadGridViewCustom();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaths.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(839, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(488, 581);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(241, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(553, 354);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(241, 484);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(553, 233);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
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
            this.btnSearch.Location = new System.Drawing.Point(681, 157);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 25);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(463, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 30);
            this.btnSave.TabIndex = 42;
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
            this.btnCancel.Location = new System.Drawing.Point(321, 655);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 30);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOrigin
            // 
            this.txtOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtOrigin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrigin.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtOrigin.Location = new System.Drawing.Point(314, 551);
            this.txtOrigin.MaxLength = 20;
            this.txtOrigin.Multiline = true;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(167, 28);
            this.txtOrigin.TabIndex = 54;
            // 
            // txtCost
            // 
            this.txtCost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCost.Location = new System.Drawing.Point(314, 603);
            this.txtCost.MaxLength = 6;
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(167, 28);
            this.txtCost.TabIndex = 55;
            // 
            // txtDestination
            // 
            this.txtDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestination.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDestination.Location = new System.Drawing.Point(592, 551);
            this.txtDestination.MaxLength = 20;
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(167, 28);
            this.txtDestination.TabIndex = 56;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("IRANYekan", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(518, 157);
            this.txtSearch.MaxLength = 75;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 25);
            this.txtSearch.TabIndex = 57;
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.lblDestination.Font = new System.Drawing.Font("IRANYekan", 6F);
            this.lblDestination.ForeColor = System.Drawing.Color.White;
            this.lblDestination.Location = new System.Drawing.Point(1055, 185);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(75, 24);
            this.lblDestination.TabIndex = 58;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrigin
            // 
            this.lblOrigin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.lblOrigin.Font = new System.Drawing.Font("IRANYekan", 6F);
            this.lblOrigin.ForeColor = System.Drawing.Color.White;
            this.lblOrigin.Location = new System.Drawing.Point(1055, 477);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(79, 24);
            this.lblOrigin.TabIndex = 59;
            this.lblOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.lblCost.Font = new System.Drawing.Font("IRANYekan", 13F);
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(1192, 650);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(73, 40);
            this.lblCost.TabIndex = 60;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridPaths
            // 
            this.gridPaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridPaths.Font = new System.Drawing.Font("IRANYekan", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPaths.Location = new System.Drawing.Point(248, 188);
            // 
            // 
            // 
            this.gridPaths.MasterTemplate.AllowAddNewRow = false;
            this.gridPaths.MasterTemplate.AllowColumnReorder = false;
            this.gridPaths.MasterTemplate.AllowDragToGroup = false;
            this.gridPaths.MasterTemplate.AllowEditRow = false;
            this.gridPaths.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCommandColumn1.AllowHide = false;
            gridViewCommandColumn1.HeaderText = "ویرایش";
            gridViewCommandColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn1.Image")));
            gridViewCommandColumn1.MaxWidth = 60;
            gridViewCommandColumn1.Name = "GridEditBtn";
            gridViewCommandColumn1.Width = 60;
            gridViewCommandColumn2.AllowHide = false;
            gridViewCommandColumn2.HeaderText = "حذف";
            gridViewCommandColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridViewCommandColumn2.Image")));
            gridViewCommandColumn2.MaxWidth = 50;
            gridViewCommandColumn2.Name = "GridDeleteBtn";
            //this.gridPaths.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            //gridViewCommandColumn1,
            //gridViewCommandColumn2});
            this.gridPaths.MasterTemplate.EnableGrouping = false;
            this.gridPaths.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.None;
            this.gridPaths.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridPaths.Name = "gridPaths";
            this.gridPaths.ReadOnly = true;
            // 
            // 
            // 
            this.gridPaths.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.gridPaths.Size = new System.Drawing.Size(538, 278);
            this.gridPaths.TabIndex = 61;
            this.gridPaths.ThemeName = "Material";
            this.gridPaths.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridPaths_CellClick);
            // 
            // frmPaths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gridPaths);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmPaths";
            this.Text = "Paths";
            this.Load += new System.EventHandler(this.frmPaths_Load);
            this.Controls.SetChildIndex(this.btnDashboard, 0);
            this.Controls.SetChildIndex(this.btnDrivers, 0);
            this.Controls.SetChildIndex(this.btnServices, 0);
            this.Controls.SetChildIndex(this.btnPaths, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.txtOrigin, 0);
            this.Controls.SetChildIndex(this.txtCost, 0);
            this.Controls.SetChildIndex(this.txtDestination, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.lblDestination, 0);
            this.Controls.SetChildIndex(this.lblOrigin, 0);
            this.Controls.SetChildIndex(this.lblCost, 0);
            this.Controls.SetChildIndex(this.gridPaths, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaths.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPaths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public Utility.SizableTextBox txtOrigin;
        public Utility.NumericTextBox txtCost;
        public Utility.SizableTextBox txtDestination;
        public Utility.SizableTextBox txtSearch;
        public System.Windows.Forms.Label lblDestination;
        public System.Windows.Forms.Label lblOrigin;
        public System.Windows.Forms.Label lblCost;
        private RadGridViewCustom gridPaths;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    }
}