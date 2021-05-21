//namespace WND
//{
//    partial class AddService
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.txtCustomer = new System.Windows.Forms.TextBox();
//            this.label2 = new System.Windows.Forms.Label();
//            this.txtDelay = new System.Windows.Forms.TextBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label4 = new System.Windows.Forms.Label();
//            this.btnAddService = new System.Windows.Forms.Button();
//            this.checkboxIsPaid = new System.Windows.Forms.CheckBox();
//            this.comboboxPaths = new System.Windows.Forms.ComboBox();
//            this.label7 = new System.Windows.Forms.Label();
//            this.txtOriginInDetail = new System.Windows.Forms.RichTextBox();
//            this.comboboxDrivers = new System.Windows.Forms.ComboBox();
//            this.txtDestinationInDetail = new System.Windows.Forms.RichTextBox();
//            this.label8 = new System.Windows.Forms.Label();
//            this.label6 = new System.Windows.Forms.Label();
//            this.txtCost = new System.Windows.Forms.TextBox();
//            this.txtCar = new System.Windows.Forms.TextBox();
//            this.label9 = new System.Windows.Forms.Label();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.Location = new System.Drawing.Point(62, 40);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(48, 22);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "مشتری";
//            // 
//            // txtCustomer
//            // 
//            this.txtCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
//            this.txtCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
//            this.txtCustomer.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtCustomer.Location = new System.Drawing.Point(118, 38);
//            this.txtCustomer.Name = "txtCustomer";
//            this.txtCustomer.Size = new System.Drawing.Size(315, 30);
//            this.txtCustomer.TabIndex = 1;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.Location = new System.Drawing.Point(71, 100);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(38, 22);
//            this.label2.TabIndex = 2;
//            this.label2.Text = "مسیر";
//            // 
//            // txtDelay
//            // 
//            this.txtDelay.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtDelay.Location = new System.Drawing.Point(118, 240);
//            this.txtDelay.Name = "txtDelay";
//            this.txtDelay.Size = new System.Drawing.Size(315, 30);
//            this.txtDelay.TabIndex = 5;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.Location = new System.Drawing.Point(30, 243);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(79, 22);
//            this.label3.TabIndex = 4;
//            this.label3.Text = "توقف(دقیقه)";
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label4.Location = new System.Drawing.Point(70, 280);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(39, 22);
//            this.label4.TabIndex = 6;
//            this.label4.Text = "راننده";
//            // 
//            // btnAddService
//            // 
//            this.btnAddService.BackColor = System.Drawing.Color.LightGreen;
//            this.btnAddService.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnAddService.Location = new System.Drawing.Point(188, 482);
//            this.btnAddService.Name = "btnAddService";
//            this.btnAddService.Size = new System.Drawing.Size(123, 55);
//            this.btnAddService.TabIndex = 8;
//            this.btnAddService.Text = "افزودن";
//            this.btnAddService.UseVisualStyleBackColor = false;
//            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
//            // 
//            // checkboxIsPaid
//            // 
//            this.checkboxIsPaid.AutoSize = true;
//            this.checkboxIsPaid.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.checkboxIsPaid.Location = new System.Drawing.Point(331, 431);
//            this.checkboxIsPaid.Name = "checkboxIsPaid";
//            this.checkboxIsPaid.Size = new System.Drawing.Size(95, 26);
//            this.checkboxIsPaid.TabIndex = 7;
//            this.checkboxIsPaid.Text = "پرداخت شده";
//            this.checkboxIsPaid.UseVisualStyleBackColor = true;
//            // 
//            // comboboxPaths
//            // 
//            this.comboboxPaths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
//            this.comboboxPaths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
//            this.comboboxPaths.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.comboboxPaths.FormattingEnabled = true;
//            this.comboboxPaths.Location = new System.Drawing.Point(118, 98);
//            this.comboboxPaths.MaxLength = 500;
//            this.comboboxPaths.Name = "comboboxPaths";
//            this.comboboxPaths.Size = new System.Drawing.Size(315, 30);
//            this.comboboxPaths.Sorted = true;
//            this.comboboxPaths.TabIndex = 2;
//            this.comboboxPaths.SelectedIndexChanged += new System.EventHandler(this.comboboxPaths_SelectedIndexChanged);
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label7.Location = new System.Drawing.Point(42, 143);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(67, 22);
//            this.label7.TabIndex = 14;
//            this.label7.Text = "آدرس مبدا";
//            // 
//            // txtOriginInDetail
//            // 
//            this.txtOriginInDetail.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtOriginInDetail.Location = new System.Drawing.Point(118, 137);
//            this.txtOriginInDetail.MaxLength = 500;
//            this.txtOriginInDetail.Multiline = false;
//            this.txtOriginInDetail.Name = "txtOriginInDetail";
//            this.txtOriginInDetail.Size = new System.Drawing.Size(315, 36);
//            this.txtOriginInDetail.TabIndex = 3;
//            this.txtOriginInDetail.Text = "";
//            // 
//            // comboboxDrivers
//            // 
//            this.comboboxDrivers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
//            this.comboboxDrivers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
//            this.comboboxDrivers.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.comboboxDrivers.FormattingEnabled = true;
//            this.comboboxDrivers.Location = new System.Drawing.Point(118, 277);
//            this.comboboxDrivers.Name = "comboboxDrivers";
//            this.comboboxDrivers.Size = new System.Drawing.Size(315, 30);
//            this.comboboxDrivers.Sorted = true;
//            this.comboboxDrivers.TabIndex = 6;
//            this.comboboxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboboxDrivers_SelectedIndexChanged);
//            // 
//            // txtDestinationInDetail
//            // 
//            this.txtDestinationInDetail.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtDestinationInDetail.Location = new System.Drawing.Point(118, 179);
//            this.txtDestinationInDetail.Multiline = false;
//            this.txtDestinationInDetail.Name = "txtDestinationInDetail";
//            this.txtDestinationInDetail.Size = new System.Drawing.Size(315, 36);
//            this.txtDestinationInDetail.TabIndex = 4;
//            this.txtDestinationInDetail.Text = "";
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label8.Location = new System.Drawing.Point(34, 184);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(76, 22);
//            this.label8.TabIndex = 17;
//            this.label8.Text = "آدرس مقصد";
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label6.Location = new System.Drawing.Point(67, 431);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(84, 22);
//            this.label6.TabIndex = 19;
//            this.label6.Text = "هزینه (تومان)";
//            // 
//            // txtCost
//            // 
//            this.txtCost.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtCost.Location = new System.Drawing.Point(158, 431);
//            this.txtCost.Name = "txtCost";
//            this.txtCost.ReadOnly = true;
//            this.txtCost.Size = new System.Drawing.Size(114, 30);
//            this.txtCost.TabIndex = 20;
//            this.txtCost.TabStop = false;
//            // 
//            // txtCar
//            // 
//            this.txtCar.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtCar.Location = new System.Drawing.Point(44, 351);
//            this.txtCar.Multiline = true;
//            this.txtCar.Name = "txtCar";
//            this.txtCar.ReadOnly = true;
//            this.txtCar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//            this.txtCar.Size = new System.Drawing.Size(389, 65);
//            this.txtCar.TabIndex = 7;
//            this.txtCar.TabStop = false;
//            // 
//            // label9
//            // 
//            this.label9.AutoSize = true;
//            this.label9.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label9.Location = new System.Drawing.Point(40, 325);
//            this.label9.Name = "label9";
//            this.label9.Size = new System.Drawing.Size(98, 22);
//            this.label9.TabIndex = 21;
//            this.label9.Text = "مشخصات خودرو";
//            // 
//            // AddService
//            // 
//            this.AcceptButton = this.btnAddService;
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(482, 568);
//            this.Controls.Add(this.txtCar);
//            this.Controls.Add(this.label9);
//            this.Controls.Add(this.txtCost);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.txtDestinationInDetail);
//            this.Controls.Add(this.label8);
//            this.Controls.Add(this.comboboxDrivers);
//            this.Controls.Add(this.txtOriginInDetail);
//            this.Controls.Add(this.label7);
//            this.Controls.Add(this.comboboxPaths);
//            this.Controls.Add(this.checkboxIsPaid);
//            this.Controls.Add(this.btnAddService);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.txtDelay);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.txtCustomer);
//            this.Controls.Add(this.label1);
//            this.MaximizeBox = false;
//            this.MaximumSize = new System.Drawing.Size(498, 607);
//            this.MinimumSize = new System.Drawing.Size(498, 607);
//            this.Name = "AddService";
//            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.RightToLeftLayout = true;
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "افزودن سرویس";
//            this.Load += new System.EventHandler(this.AddService_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox txtCustomer;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.TextBox txtDelay;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Button btnAddService;
//        private System.Windows.Forms.CheckBox checkboxIsPaid;
//        private System.Windows.Forms.ComboBox comboboxPaths;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.RichTextBox txtOriginInDetail;
//        private System.Windows.Forms.ComboBox comboboxDrivers;
//        private System.Windows.Forms.RichTextBox txtDestinationInDetail;
//        private System.Windows.Forms.Label label8;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.TextBox txtCost;
//        private System.Windows.Forms.TextBox txtCar;
//        private System.Windows.Forms.Label label9;
//    }
//}