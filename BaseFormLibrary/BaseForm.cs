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
    public class BaseForm:Form
    {
        Dictionary<string, bool> MenuItems = new Dictionary<string, bool>();
        Dictionary<string, Bitmap> MenuImageSources = new Dictionary<string, Bitmap>();


        private Label lblTaxiName;
        private PictureBox pictureboxProfile;
        private PictureBox pictureboxChangeCamera;
        private Label lblFullName;
        private Label lblRule;
        public PictureBox btnDashboard;
        public PictureBox btnDrivers;
        public PictureBox btnServices;
        public PictureBox btnPaths;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label lblDateTime;
        public PictureBox btnExit;
        private PictureBox pictureBox1;
        //private FormCustom _sourceForm;
        

        public BaseForm()
        {
            MenuItems.Add("Dashboard", false);
            MenuItems.Add("Drivers", false);
            MenuItems.Add("Services", false);
            MenuItems.Add("Paths", false);

            MenuImageSources.Add("Dashboard", Properties.Resources.Dashboard);
            MenuImageSources.Add("DashboardOut", Properties.Resources.Dashboard_out);
            MenuImageSources.Add("Drivers", Properties.Resources.Drivers);
            MenuImageSources.Add("DriversOut", Properties.Resources.Drivers_out);
            MenuImageSources.Add("Services", Properties.Resources.Services);
            MenuImageSources.Add("ServicesOut", Properties.Resources.Services_out);
            MenuImageSources.Add("Paths", Properties.Resources.Paths);
            MenuImageSources.Add("PathsOut", Properties.Resources.Paths_out);



            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Size = new System.Drawing.Size(1370,749);
            this.WindowState = FormWindowState.Maximized;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.InitializeComponent();
            Bitmap profile_image = Resources.user_profile;
            profile_image.MakeTransparent(Color.Transparent);
            this.pictureboxProfile.Image = (Image)profile_image;
            this.Show();
            //if (sourceForm != null)
            //{
            //    _sourceForm = sourceForm;
            //    _sourceForm.Hide();
            //    this.Show();
            //}

            
        }

        void ResetMenu()
        {
            btnDashboard.Image = Properties.Resources.Dashboard;
            btnDashboard.Width = 93;
            btnDashboard.Height = 67;
            btnDashboard.BackColor = Color.FromArgb(246, 190, 100);
            btnDashboard.Refresh();

            btnDrivers.Image = Properties.Resources.Drivers;
            btnDrivers.Refresh();
            btnDrivers.Width = 93;
            btnDrivers.Height = 67;
            btnDrivers.BackColor = Color.FromArgb(246, 190, 100);

            btnServices.Image = Properties.Resources.Services;
            btnServices.Refresh();
            btnServices.Width = 93;
            btnServices.Height = 67;
            btnServices.BackColor = Color.FromArgb(246, 190, 100);

            btnPaths.Image = Properties.Resources.Paths;
            btnPaths.Refresh();
            btnPaths.Width = 93;
            btnPaths.Height = 67;
            btnPaths.BackColor = Color.FromArgb(246, 190, 100);
        }

        void ChangeMenuSelectedItem(string ItemName)
        {
            string ItemNameWithoutBtn = ItemName.Replace("btn", "");
            bool IsSelected = MenuItems.TryGetValue(ItemNameWithoutBtn, out IsSelected);
            PictureBox btn = this.Controls.OfType<PictureBox>().Where(p => p.Name == ItemName).Single();
            btn.SizeMode = PictureBoxSizeMode.StretchImage;

            ResetMenu();
            
            if (!IsSelected)
            {
                btn.Image = MenuImageSources[ItemNameWithoutBtn];
                btn.Refresh();
                MenuItems[ItemNameWithoutBtn] = false;
                btn.Width = 93;
                btn.BackColor = Color.FromArgb(246, 190, 100);
            }
            else
            {
                btn.Image = MenuImageSources[ItemNameWithoutBtn + "Out"];
                btn.Refresh();
                MenuItems[ItemNameWithoutBtn] = true;
                btn.Width = 180;
                btn.BackColor = Color.FromArgb(242, 242, 242);
            }

            btn.Height = 67;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.OK)
            {
                
            }
            else
            {
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }


        private void InitializeComponent()
        {
            this.lblTaxiName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblRule = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnPaths = new System.Windows.Forms.PictureBox();
            this.btnServices = new System.Windows.Forms.PictureBox();
            this.btnDrivers = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.PictureBox();
            this.pictureboxChangeCamera = new System.Windows.Forms.PictureBox();
            this.pictureboxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxChangeCamera)).BeginInit();
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
            this.lblTaxiName.TabIndex = 1;
            this.lblTaxiName.Text = "تاکسی دار";
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
            this.lblFullName.TabIndex = 5;
            //this.lblFullName.Text = "پدرام یمینی";
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
            this.lblRule.TabIndex = 6;
            this.lblRule.Text = "مدیر تاکسی";
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
            this.lblDateTime.TabIndex = 14;
            //this.lblDateTime.Text = "چهارشنبه 22 اردیبهشت 1400";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::BaseFormLibrary.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(4, 645);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 67);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 15;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPaths
            // 
            this.btnPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnPaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaths.Image = global::BaseFormLibrary.Properties.Resources.Paths;
            this.btnPaths.Location = new System.Drawing.Point(4, 357);
            this.btnPaths.Name = "btnPaths";
            this.btnPaths.Size = new System.Drawing.Size(93, 67);
            this.btnPaths.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPaths.TabIndex = 10;
            this.btnPaths.TabStop = false;
            this.btnPaths.Click += new System.EventHandler(this.btnPaths_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.Image = global::BaseFormLibrary.Properties.Resources.Services;
            this.btnServices.Location = new System.Drawing.Point(4, 265);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(93, 67);
            this.btnServices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnServices.TabIndex = 9;
            this.btnServices.TabStop = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivers.Image = global::BaseFormLibrary.Properties.Resources.Drivers;
            this.btnDrivers.Location = new System.Drawing.Point(4, 173);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(93, 67);
            this.btnDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDrivers.TabIndex = 8;
            this.btnDrivers.TabStop = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Image = global::BaseFormLibrary.Properties.Resources.Dashboard;
            this.btnDashboard.Location = new System.Drawing.Point(4, 81);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(93, 67);
            this.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureboxChangeCamera
            // 
            this.pictureboxChangeCamera.BackColor = System.Drawing.Color.White;
            this.pictureboxChangeCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureboxChangeCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxChangeCamera.Image = global::BaseFormLibrary.Properties.Resources.Icon_feather_camera;
            this.pictureboxChangeCamera.Location = new System.Drawing.Point(1162, 85);
            this.pictureboxChangeCamera.Name = "pictureboxChangeCamera";
            this.pictureboxChangeCamera.Size = new System.Drawing.Size(19, 15);
            this.pictureboxChangeCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxChangeCamera.TabIndex = 3;
            this.pictureboxChangeCamera.TabStop = false;
            // 
            // pictureboxProfile
            // 
            this.pictureboxProfile.BackColor = System.Drawing.Color.White;
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
            this.pictureBox1.Image = global::BaseFormLibrary.Properties.Resources.BaseForm__2_;
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
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnPaths);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblRule);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureboxChangeCamera);
            this.Controls.Add(this.pictureboxProfile);
            this.Controls.Add(this.lblTaxiName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxChangeCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        protected virtual void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Today.ToPersianDateString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChangeMenuSelectedItem(nameof(btnDashboard));
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            ChangeMenuSelectedItem(nameof(btnDrivers));
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ChangeMenuSelectedItem(nameof(btnServices));
        }

        private void btnPaths_Click(object sender, EventArgs e)
        {
            ChangeMenuSelectedItem(nameof(btnPaths));
        }
    }
}
