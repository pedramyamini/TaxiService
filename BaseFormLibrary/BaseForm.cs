using BaseFormLibrary.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;


namespace BaseFormLibrary
{
    public class BaseForm : Form
    {

        protected bool SwitchBetweenForms = false;


        private Label lblTaxiName;
        private PictureBox pictureboxProfile;
        private Label lblFullName;
        private Label lblRule;
        protected Button btnDashboard;
        protected Button btnDrivers;
        protected Button btnServices;
        protected Button btnPaths;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label lblDateTime;
        public Button btnExit;
        private PictureBox pictureBox1;
        //private FormCustom _sourceForm;


        public BaseForm()
        {

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Size = new System.Drawing.Size(1386, 788);
            this.MaximumSize = new System.Drawing.Size(1386, 788);
            this.MinimumSize = new System.Drawing.Size(1386, 788);
            this.WindowState = FormWindowState.Maximized;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            //this.pictureboxProfile.Image = Resources.user_profile;


            this.InitializeComponent();

            //to avoid designer error
            if (Session.CurrentUser != null)
            {
                lblRule.Text = Utility.Session.CurrentUser.Role == Models.Roles.Admin ? "مدیر" : "منشی";
                lblDateTime.Text = DateTime.Today.ToPersianDateString();
                lblFullName.Text = Session.CurrentUser.FullName;
                lblTaxiName.Text = Session.CurrentUser.TaxiName;
            }

            this.Show();

        }
        protected void CloseWithoutAsk()
        {
            this.SwitchBetweenForms = true;
            this.Close();
        }
        void ResetMenu()
        {
            btnDashboard.BackgroundImage = Properties.Resources.Dashboard;
            btnDashboard.Width = 93;
            btnDashboard.Height = 67;
            btnDashboard.BackColor = Color.FromArgb(246, 190, 100);
            btnDashboard.Refresh();

            btnDrivers.BackgroundImage = Properties.Resources.Drivers;
            btnDrivers.Refresh();
            btnDrivers.Width = 93;
            btnDrivers.Height = 67;
            btnDrivers.BackColor = Color.FromArgb(246, 190, 100);

            btnServices.BackgroundImage = Properties.Resources.Services;
            btnServices.Refresh();
            btnServices.Width = 93;
            btnServices.Height = 67;
            btnServices.BackColor = Color.FromArgb(246, 190, 100);

            btnPaths.BackgroundImage = Properties.Resources.Paths;
            btnPaths.Refresh();
            btnPaths.Width = 93;
            btnPaths.Height = 67;
            btnPaths.BackColor = Color.FromArgb(246, 190, 100);
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!SwitchBetweenForms)
            {
                DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
                if (dr == DialogResult.OK)
                {
                    (Utility.Session.LoginForm as Form).Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }


        protected void InitializeComponent()
        {
            this.lblTaxiName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPaths = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureboxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaxiName
            // 
            this.lblTaxiName.BackColor = System.Drawing.Color.White;
            this.lblTaxiName.Font = new System.Drawing.Font("IRANYekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxiName.Location = new System.Drawing.Point(206, 36);
            this.lblTaxiName.Name = "lblTaxiName";
            this.lblTaxiName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTaxiName.Size = new System.Drawing.Size(215, 35);
            this.lblTaxiName.TabIndex = 1000;
            this.lblTaxiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.White;
            this.lblFullName.Font = new System.Drawing.Font("IRANYekan", 8F);
            this.lblFullName.Location = new System.Drawing.Point(1040, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFullName.Size = new System.Drawing.Size(94, 32);
            this.lblFullName.TabIndex = 1002;
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRule
            // 
            this.lblRule.BackColor = System.Drawing.Color.White;
            this.lblRule.Font = new System.Drawing.Font("IRANYekan", 8F);
            this.lblRule.Location = new System.Drawing.Point(1208, 36);
            this.lblRule.Name = "lblRule";
            this.lblRule.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRule.Size = new System.Drawing.Size(91, 31);
            this.lblRule.TabIndex = 1003;
            this.lblRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.White;
            this.lblDateTime.Font = new System.Drawing.Font("IRANYekan", 7F);
            this.lblDateTime.Location = new System.Drawing.Point(875, 39);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDateTime.Size = new System.Drawing.Size(134, 28);
            this.lblDateTime.TabIndex = 1001;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnExit.BackgroundImage = global::BaseFormLibrary.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(55)))));
            this.btnExit.Location = new System.Drawing.Point(4, 645);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 67);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPaths
            // 
            this.btnPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnPaths.BackgroundImage = global::BaseFormLibrary.Properties.Resources.Paths;
            this.btnPaths.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaths.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnPaths.FlatAppearance.BorderSize = 0;
            this.btnPaths.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnPaths.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnPaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(55)))));
            this.btnPaths.Location = new System.Drawing.Point(4, 357);
            this.btnPaths.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaths.Name = "btnPaths";
            this.btnPaths.Size = new System.Drawing.Size(93, 67);
            this.btnPaths.TabIndex = 4;
            this.btnPaths.UseVisualStyleBackColor = false;
            this.btnPaths.Click += new System.EventHandler(this.btnPaths_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnServices.BackgroundImage = global::BaseFormLibrary.Properties.Resources.Services;
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(55)))));
            this.btnServices.Location = new System.Drawing.Point(4, 265);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(93, 67);
            this.btnServices.TabIndex = 3;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDrivers.BackgroundImage = global::BaseFormLibrary.Properties.Resources.Drivers;
            this.btnDrivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(55)))));
            this.btnDrivers.Location = new System.Drawing.Point(4, 173);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(93, 67);
            this.btnDrivers.TabIndex = 2;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDashboard.BackgroundImage = global::BaseFormLibrary.Properties.Resources.Dashboard;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(55)))));
            this.btnDashboard.Location = new System.Drawing.Point(4, 81);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(93, 67);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureboxProfile
            // 
            this.pictureboxProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pictureboxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureboxProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxProfile.Image = global::BaseFormLibrary.Properties.Resources.user_profile;
            this.pictureboxProfile.Location = new System.Drawing.Point(1140, 21);
            this.pictureboxProfile.Name = "pictureboxProfile";
            this.pictureboxProfile.Size = new System.Drawing.Size(62, 65);
            this.pictureboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxProfile.TabIndex = 2;
            this.pictureboxProfile.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BaseFormLibrary.Properties.Resources.BaseForm_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 749);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 50);
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 50);
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // BaseForm
            // 
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnPaths);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureboxProfile);
            this.Controls.Add(this.lblTaxiName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1386, 788);
            this.MinimumSize = new System.Drawing.Size(1364, 766);
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        protected virtual void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void BaseForm_Load(object sender, EventArgs e)
        {
            
        }

        protected virtual void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDrivers_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnServices_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnPaths_Click(object sender, EventArgs e)
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.OnDispose();
            }
            base.Dispose(disposing);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// اینو گذاشتم فقط واسه اینکه یه زمانی خواستید اوراید کنید
        /// </summary>
        protected virtual void OnDispose()
        {

        }
    }
}
