using WND.Utility;

namespace WND.Path
{
    partial class AddPath
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCost = new WND.Utility.NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مبدا";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigin.Location = new System.Drawing.Point(117, 47);
            this.txtOrigin.MaxLength = 300;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(180, 26);
            this.txtOrigin.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(117, 91);
            this.txtDestination.MaxLength = 300;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(180, 26);
            this.txtDestination.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "مقصد";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(117, 137);
            this.txtCost.MaxLength = 8;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(180, 26);
            this.txtCost.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "هزینه(تومان)";
            // 
            // btnAddPath
            // 
            this.btnAddPath.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddPath.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPath.ForeColor = System.Drawing.Color.Black;
            this.btnAddPath.Location = new System.Drawing.Point(130, 202);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(114, 50);
            this.btnAddPath.TabIndex = 4;
            this.btnAddPath.Text = "افزودن";
            this.btnAddPath.UseVisualStyleBackColor = false;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // AddPath
            // 
            this.AcceptButton = this.btnAddPath;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 282);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 321);
            this.MinimumSize = new System.Drawing.Size(363, 321);
            this.Name = "AddPath";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن مسیر";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPath_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPath_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label2;
        private NumericTextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPath;
    }
}