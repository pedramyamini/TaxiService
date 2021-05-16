
using BaseFormLibrary;
using System.Windows.Forms;

namespace WND
{
    partial class Dashboard : BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReportThumbnail = new System.Windows.Forms.PictureBox();
            this.btnCustomersThumbnail = new System.Windows.Forms.PictureBox();
            this.btnPathsThumbnail = new System.Windows.Forms.PictureBox();
            this.btnServicesThumbnail = new System.Windows.Forms.PictureBox();
            this.btnDriversThumbnail = new System.Windows.Forms.PictureBox();
            this.btnSecretaryThumbnail = new System.Windows.Forms.PictureBox();
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnSecretaryThumbnail);
            this.Controls.Add(this.btnDriversThumbnail);
            this.Controls.Add(this.btnServicesThumbnail);
            this.Controls.Add(this.btnPathsThumbnail);
            this.Controls.Add(this.btnCustomersThumbnail);
            this.Controls.Add(this.btnReportThumbnail);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
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

        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox btnReportThumbnail;
        private PictureBox btnCustomersThumbnail;
        private PictureBox btnPathsThumbnail;
        private PictureBox btnServicesThumbnail;
        private PictureBox btnDriversThumbnail;
        private PictureBox btnSecretaryThumbnail;
    }
}