using System.Windows.Forms;
using WND.Utility;

namespace WND.Car
{
    partial class EditCar
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
            this.btnEditCar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLicencePlate1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxDrivers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicencePlate2 = new System.Windows.Forms.TextBox();
            this.txtLicencePlate3 = new System.Windows.Forms.TextBox();
            this.txtLicencePlate4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkboxShowLicenseExample = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(157, 267);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(114, 50);
            this.btnEditCar.TabIndex = 17;
            this.btnEditCar.Text = "ویرایش";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(163, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 26);
            this.textBox3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "رنگ";
            // 
            // txtLicencePlate1
            // 
            this.txtLicencePlate1.BackColor = System.Drawing.Color.White;
            this.txtLicencePlate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencePlate1.Location = new System.Drawing.Point(322, 154);
            this.txtLicencePlate1.Name = "txtLicencePlate1";
            this.txtLicencePlate1.Size = new System.Drawing.Size(38, 26);
            this.txtLicencePlate1.TabIndex = 14;
            this.txtLicencePlate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "پلاک(از چپ به راست)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(163, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "مدل خودرو";
            // 
            // comboboxDrivers
            // 
            this.comboboxDrivers.FormattingEnabled = true;
            this.comboboxDrivers.Location = new System.Drawing.Point(162, 64);
            this.comboboxDrivers.Name = "comboboxDrivers";
            this.comboboxDrivers.Size = new System.Drawing.Size(169, 21);
            this.comboboxDrivers.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "راننده";
            // 
            // txtLicencePlate2
            // 
            this.txtLicencePlate2.BackColor = System.Drawing.Color.White;
            this.txtLicencePlate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencePlate2.Location = new System.Drawing.Point(277, 154);
            this.txtLicencePlate2.Name = "txtLicencePlate2";
            this.txtLicencePlate2.Size = new System.Drawing.Size(38, 26);
            this.txtLicencePlate2.TabIndex = 18;
            this.txtLicencePlate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicencePlate3
            // 
            this.txtLicencePlate3.BackColor = System.Drawing.Color.White;
            this.txtLicencePlate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencePlate3.Location = new System.Drawing.Point(207, 154);
            this.txtLicencePlate3.Name = "txtLicencePlate3";
            this.txtLicencePlate3.Size = new System.Drawing.Size(64, 26);
            this.txtLicencePlate3.TabIndex = 19;
            this.txtLicencePlate3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicencePlate4
            // 
            this.txtLicencePlate4.BackColor = System.Drawing.Color.White;
            this.txtLicencePlate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicencePlate4.Location = new System.Drawing.Point(163, 154);
            this.txtLicencePlate4.Name = "txtLicencePlate4";
            this.txtLicencePlate4.Size = new System.Drawing.Size(38, 26);
            this.txtLicencePlate4.TabIndex = 20;
            this.txtLicencePlate4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "۲ رقم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "۱ حرف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "۳ رقم";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "۲ رقم";
            // 
            // checkboxShowLicenseExample
            // 
            this.checkboxShowLicenseExample.AutoSize = true;
            this.checkboxShowLicenseExample.Location = new System.Drawing.Point(251, 190);
            this.checkboxShowLicenseExample.Name = "checkboxShowLicenseExample";
            this.checkboxShowLicenseExample.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkboxShowLicenseExample.Size = new System.Drawing.Size(110, 17);
            this.checkboxShowLicenseExample.TabIndex = 25;
            this.checkboxShowLicenseExample.Text = "مشاهده نمونه پلاک";
            this.checkboxShowLicenseExample.UseVisualStyleBackColor = true;
            this.checkboxShowLicenseExample.CheckedChanged += new System.EventHandler(this.checkboxShowLicenseExample_CheckedChanged);
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 349);
            this.Controls.Add(this.checkboxShowLicenseExample);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLicencePlate4);
            this.Controls.Add(this.txtLicencePlate3);
            this.Controls.Add(this.txtLicencePlate2);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLicencePlate1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxDrivers);
            this.Controls.Add(this.label1);
            this.Name = "EditCar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش خودرو";
            this.Load += new System.EventHandler(this.EditCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLicencePlate1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboboxDrivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLicencePlate2;
        private System.Windows.Forms.TextBox txtLicencePlate3;
        private System.Windows.Forms.TextBox txtLicencePlate4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CheckBox checkboxShowLicenseExample;
    }
}