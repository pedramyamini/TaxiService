using WND.Utility;

namespace WND
{
    partial class EditService
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
            this.datagridServices = new System.Windows.Forms.DataGridView();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDestinationInDetail = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboboxDrivers = new System.Windows.Forms.ComboBox();
            this.txtOriginInDetail = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboboxPaths = new System.Windows.Forms.ComboBox();
            this.checkboxIsPaid = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCost = new WND.Utility.NumericTextBox();
            this.txtDelay = new WND.Utility.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridServices)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridServices
            // 
            this.datagridServices.AllowUserToAddRows = false;
            this.datagridServices.AllowUserToDeleteRows = false;
            this.datagridServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.datagridServices.Location = new System.Drawing.Point(0, 0);
            this.datagridServices.MultiSelect = false;
            this.datagridServices.Name = "datagridServices";
            this.datagridServices.ReadOnly = true;
            this.datagridServices.RowTemplate.ReadOnly = true;
            this.datagridServices.Size = new System.Drawing.Size(1044, 197);
            this.datagridServices.TabIndex = 0;
            this.datagridServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridServices_CellClick);
            this.datagridServices.SelectionChanged += new System.EventHandler(this.datagridServices_SelectionChanged);
            // 
            // txtCar
            // 
            this.txtCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCar.Location = new System.Drawing.Point(563, 328);
            this.txtCar.Multiline = true;
            this.txtCar.Name = "txtCar";
            this.txtCar.ReadOnly = true;
            this.txtCar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCar.Size = new System.Drawing.Size(458, 108);
            this.txtCar.TabIndex = 33;
            this.txtCar.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(559, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "مشخصات خودرو";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(606, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "هزینه (تومان)";
            // 
            // txtDestinationInDetail
            // 
            this.txtDestinationInDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationInDetail.Location = new System.Drawing.Point(105, 401);
            this.txtDestinationInDetail.Multiline = false;
            this.txtDestinationInDetail.Name = "txtDestinationInDetail";
            this.txtDestinationInDetail.Size = new System.Drawing.Size(375, 36);
            this.txtDestinationInDetail.TabIndex = 4;
            this.txtDestinationInDetail.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(13, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "آدرس مقصد";
            // 
            // comboboxDrivers
            // 
            this.comboboxDrivers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxDrivers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxDrivers.FormattingEnabled = true;
            this.comboboxDrivers.Location = new System.Drawing.Point(637, 259);
            this.comboboxDrivers.Name = "comboboxDrivers";
            this.comboboxDrivers.Size = new System.Drawing.Size(384, 33);
            this.comboboxDrivers.Sorted = true;
            this.comboboxDrivers.TabIndex = 6;
            this.comboboxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboboxDrivers_SelectedIndexChanged);
            // 
            // txtOriginInDetail
            // 
            this.txtOriginInDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginInDetail.Location = new System.Drawing.Point(105, 359);
            this.txtOriginInDetail.MaxLength = 500;
            this.txtOriginInDetail.Multiline = false;
            this.txtOriginInDetail.Name = "txtOriginInDetail";
            this.txtOriginInDetail.Size = new System.Drawing.Size(375, 36);
            this.txtOriginInDetail.TabIndex = 3;
            this.txtOriginInDetail.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(21, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "آدرس مبدا";
            // 
            // comboboxPaths
            // 
            this.comboboxPaths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxPaths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxPaths.FormattingEnabled = true;
            this.comboboxPaths.Location = new System.Drawing.Point(105, 320);
            this.comboboxPaths.MaxLength = 500;
            this.comboboxPaths.Name = "comboboxPaths";
            this.comboboxPaths.Size = new System.Drawing.Size(375, 33);
            this.comboboxPaths.Sorted = true;
            this.comboboxPaths.TabIndex = 2;
            this.comboboxPaths.SelectedIndexChanged += new System.EventHandler(this.comboboxPaths_SelectedIndexChanged);
            // 
            // checkboxIsPaid
            // 
            this.checkboxIsPaid.AutoSize = true;
            this.checkboxIsPaid.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkboxIsPaid.Location = new System.Drawing.Point(916, 447);
            this.checkboxIsPaid.Name = "checkboxIsPaid";
            this.checkboxIsPaid.Size = new System.Drawing.Size(102, 27);
            this.checkboxIsPaid.TabIndex = 7;
            this.checkboxIsPaid.Text = "پرداخت شده";
            this.checkboxIsPaid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(587, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "راننده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(9, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "توقف (دقیقه)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(54, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "مسیر";
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(105, 260);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(375, 30);
            this.txtCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(45, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "مشتری";
            // 
            // btnEditService
            // 
            this.btnEditService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditService.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditService.ForeColor = System.Drawing.Color.White;
            this.btnEditService.Location = new System.Drawing.Point(677, 496);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(134, 50);
            this.btnEditService.TabIndex = 9;
            this.btnEditService.Text = "ویرایش";
            this.btnEditService.UseVisualStyleBackColor = false;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteService.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteService.ForeColor = System.Drawing.Color.White;
            this.btnDeleteService.Location = new System.Drawing.Point(818, 496);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(134, 50);
            this.btnDeleteService.TabIndex = 10;
            this.btnDeleteService.Text = "حذف";
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(522, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 50);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "پاک کردن ورودی‌ها";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(56, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 23);
            this.label10.TabIndex = 43;
            this.label10.Text = "تاریخ";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(600, 206);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 30);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(341, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 23);
            this.label11.TabIndex = 45;
            this.label11.Text = "جستجو (بر اساس نام و شماره همراه و مسیر)";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(916, 206);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 30);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(697, 447);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(114, 30);
            this.txtCost.TabIndex = 39;
            this.txtCost.TabStop = false;
            // 
            // txtDelay
            // 
            this.txtDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelay.Location = new System.Drawing.Point(105, 443);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(375, 30);
            this.txtDelay.TabIndex = 5;
            // 
            // EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 554);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnEditService);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDestinationInDetail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboboxDrivers);
            this.Controls.Add(this.txtOriginInDetail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboboxPaths);
            this.Controls.Add(this.checkboxIsPaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridServices);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1006, 593);
            this.Name = "EditService";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش سرویس";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditService_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditService_FormClosed);
            this.Load += new System.EventHandler(this.EditService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridServices;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label label9;
        private NumericTextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDestinationInDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboboxDrivers;
        private System.Windows.Forms.RichTextBox txtOriginInDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboboxPaths;
        private System.Windows.Forms.CheckBox checkboxIsPaid;
        private System.Windows.Forms.Label label4;
        private NumericTextBox txtDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
    }
}