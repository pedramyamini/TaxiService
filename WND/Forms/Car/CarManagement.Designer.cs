﻿//using System.Windows.Forms;
//using Utility;

//namespace WND.Car
//{
//    partial class EditCar
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
//            this.btnEditCar = new System.Windows.Forms.Button();
//            this.txtColor = new System.Windows.Forms.TextBox();
//            this.label4 = new System.Windows.Forms.Label();
//            this.txtLicencePlate1 = new Utility.NumericTextBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.txtModel = new System.Windows.Forms.TextBox();
//            this.label2 = new System.Windows.Forms.Label();
//            this.comboboxDrivers = new System.Windows.Forms.ComboBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.txtLicencePlate2 = new System.Windows.Forms.TextBox();
//            this.txtLicencePlate3 = new Utility.NumericTextBox();
//            this.txtLicencePlate4 = new Utility.NumericTextBox();
//            this.label5 = new System.Windows.Forms.Label();
//            this.label6 = new System.Windows.Forms.Label();
//            this.label7 = new System.Windows.Forms.Label();
//            this.label8 = new System.Windows.Forms.Label();
//            this.checkboxShowLicenseExample = new System.Windows.Forms.CheckBox();
//            this.btnDelete = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // btnEditCar
//            // 
//            this.btnEditCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
//            this.btnEditCar.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnEditCar.ForeColor = System.Drawing.Color.White;
//            this.btnEditCar.Location = new System.Drawing.Point(93, 268);
//            this.btnEditCar.Name = "btnEditCar";
//            this.btnEditCar.Size = new System.Drawing.Size(114, 50);
//            this.btnEditCar.TabIndex = 8;
//            this.btnEditCar.Text = "ویرایش";
//            this.btnEditCar.UseVisualStyleBackColor = false;
//            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
//            // 
//            // txtColor
//            // 
//            this.txtColor.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtColor.Location = new System.Drawing.Point(170, 216);
//            this.txtColor.Name = "txtColor";
//            this.txtColor.Size = new System.Drawing.Size(198, 30);
//            this.txtColor.TabIndex = 7;
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label4.Location = new System.Drawing.Point(133, 219);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(31, 22);
//            this.label4.TabIndex = 15;
//            this.label4.Text = "رنگ";
//            // 
//            // txtLicencePlate1
//            // 
//            this.txtLicencePlate1.BackColor = System.Drawing.Color.White;
//            this.txtLicencePlate1.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtLicencePlate1.Location = new System.Drawing.Point(329, 145);
//            this.txtLicencePlate1.MaxLength = 2;
//            this.txtLicencePlate1.Name = "txtLicencePlate1";
//            this.txtLicencePlate1.Size = new System.Drawing.Size(38, 30);
//            this.txtLicencePlate1.TabIndex = 3;
//            this.txtLicencePlate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.Location = new System.Drawing.Point(35, 148);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(129, 22);
//            this.label3.TabIndex = 13;
//            this.label3.Text = "پلاک (از چپ به راست)";
//            // 
//            // txtModel
//            // 
//            this.txtModel.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtModel.Location = new System.Drawing.Point(170, 82);
//            this.txtModel.Name = "txtModel";
//            this.txtModel.Size = new System.Drawing.Size(198, 30);
//            this.txtModel.TabIndex = 2;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.Location = new System.Drawing.Point(96, 85);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(67, 22);
//            this.label2.TabIndex = 11;
//            this.label2.Text = "مدل خودرو";
//            // 
//            // comboboxDrivers
//            // 
//            this.comboboxDrivers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
//            this.comboboxDrivers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
//            this.comboboxDrivers.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.comboboxDrivers.FormattingEnabled = true;
//            this.comboboxDrivers.Location = new System.Drawing.Point(169, 47);
//            this.comboboxDrivers.Name = "comboboxDrivers";
//            this.comboboxDrivers.Size = new System.Drawing.Size(199, 30);
//            this.comboboxDrivers.TabIndex = 1;
//            this.comboboxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboboxDrivers_SelectedIndexChanged);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.Location = new System.Drawing.Point(124, 50);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(39, 22);
//            this.label1.TabIndex = 9;
//            this.label1.Text = "راننده";
//            // 
//            // txtLicencePlate2
//            // 
//            this.txtLicencePlate2.BackColor = System.Drawing.Color.White;
//            this.txtLicencePlate2.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtLicencePlate2.Location = new System.Drawing.Point(284, 145);
//            this.txtLicencePlate2.MaxLength = 1;
//            this.txtLicencePlate2.Name = "txtLicencePlate2";
//            this.txtLicencePlate2.Size = new System.Drawing.Size(38, 30);
//            this.txtLicencePlate2.TabIndex = 4;
//            this.txtLicencePlate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            this.txtLicencePlate2.TextChanged += new System.EventHandler(this.txtLicencePlate2_TextChanged);
//            this.txtLicencePlate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicencePlate2_KeyPress);
//            // 
//            // txtLicencePlate3
//            // 
//            this.txtLicencePlate3.BackColor = System.Drawing.Color.White;
//            this.txtLicencePlate3.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtLicencePlate3.Location = new System.Drawing.Point(214, 145);
//            this.txtLicencePlate3.MaxLength = 3;
//            this.txtLicencePlate3.Name = "txtLicencePlate3";
//            this.txtLicencePlate3.Size = new System.Drawing.Size(64, 30);
//            this.txtLicencePlate3.TabIndex = 5;
//            this.txtLicencePlate3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            // 
//            // txtLicencePlate4
//            // 
//            this.txtLicencePlate4.BackColor = System.Drawing.Color.White;
//            this.txtLicencePlate4.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtLicencePlate4.Location = new System.Drawing.Point(170, 145);
//            this.txtLicencePlate4.MaxLength = 2;
//            this.txtLicencePlate4.Name = "txtLicencePlate4";
//            this.txtLicencePlate4.Size = new System.Drawing.Size(38, 30);
//            this.txtLicencePlate4.TabIndex = 6;
//            this.txtLicencePlate4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label5.Location = new System.Drawing.Point(329, 121);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(40, 22);
//            this.label5.TabIndex = 21;
//            this.label5.Text = "۲ رقم";
//            this.label5.Click += new System.EventHandler(this.label5_Click);
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label6.Location = new System.Drawing.Point(280, 121);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(43, 22);
//            this.label6.TabIndex = 22;
//            this.label6.Text = "۱ حرف";
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label7.Location = new System.Drawing.Point(223, 121);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(42, 22);
//            this.label7.TabIndex = 23;
//            this.label7.Text = "۳ رقم";
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label8.Location = new System.Drawing.Point(168, 121);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(40, 22);
//            this.label8.TabIndex = 24;
//            this.label8.Text = "۲ رقم";
//            // 
//            // checkboxShowLicenseExample
//            // 
//            this.checkboxShowLicenseExample.AutoSize = true;
//            this.checkboxShowLicenseExample.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.checkboxShowLicenseExample.Location = new System.Drawing.Point(262, 183);
//            this.checkboxShowLicenseExample.Name = "checkboxShowLicenseExample";
//            this.checkboxShowLicenseExample.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.checkboxShowLicenseExample.Size = new System.Drawing.Size(133, 26);
//            this.checkboxShowLicenseExample.TabIndex = 25;
//            this.checkboxShowLicenseExample.TabStop = false;
//            this.checkboxShowLicenseExample.Text = "مشاهده نمونه پلاک";
//            this.checkboxShowLicenseExample.UseVisualStyleBackColor = true;
//            this.checkboxShowLicenseExample.CheckedChanged += new System.EventHandler(this.checkboxShowLicenseExample_CheckedChanged);
//            // 
//            // btnDelete
//            // 
//            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
//            this.btnDelete.Font = new System.Drawing.Font("IRANYekan", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnDelete.ForeColor = System.Drawing.Color.White;
//            this.btnDelete.Location = new System.Drawing.Point(231, 268);
//            this.btnDelete.Name = "btnDelete";
//            this.btnDelete.Size = new System.Drawing.Size(114, 50);
//            this.btnDelete.TabIndex = 9;
//            this.btnDelete.Text = "حذف";
//            this.btnDelete.UseVisualStyleBackColor = false;
//            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//            // 
//            // EditCar
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(429, 361);
//            this.Controls.Add(this.btnDelete);
//            this.Controls.Add(this.checkboxShowLicenseExample);
//            this.Controls.Add(this.label8);
//            this.Controls.Add(this.label7);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.txtLicencePlate4);
//            this.Controls.Add(this.txtLicencePlate3);
//            this.Controls.Add(this.txtLicencePlate2);
//            this.Controls.Add(this.btnEditCar);
//            this.Controls.Add(this.txtColor);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.txtLicencePlate1);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.txtModel);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.comboboxDrivers);
//            this.Controls.Add(this.label1);
//            this.MaximizeBox = false;
//            this.MaximumSize = new System.Drawing.Size(445, 400);
//            this.MinimumSize = new System.Drawing.Size(445, 400);
//            this.Name = "EditCar";
//            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
//            this.RightToLeftLayout = true;
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "ویرایش خودرو";
//            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditCar_FormClosed);
//            this.Load += new System.EventHandler(this.EditCar_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Button btnEditCar;
//        private System.Windows.Forms.TextBox txtColor;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.TextBox txtModel;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.ComboBox comboboxDrivers;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox txtLicencePlate2;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.Label label8;
//        private CheckBox checkboxShowLicenseExample;
//        private Button btnDelete;
//        private NumericTextBox txtLicencePlate1;
//        private NumericTextBox txtLicencePlate3;
//        private NumericTextBox txtLicencePlate4;
//    }
//}