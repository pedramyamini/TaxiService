using BaseFormLibrary.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BaseFormLibrary
{
    public class BaseForm:Form
    {
        private Label lblTaxiName;
        private PictureBox profile;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        //private FormCustom _sourceForm;

        public BaseForm()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Size = new System.Drawing.Size(1370,749);
            this.WindowState = FormWindowState.Maximized;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.InitializeComponent();
            Bitmap profile_image = Resources.user_profile;
            profile_image.MakeTransparent(Color.Transparent);
            this.profile.Image = (Image)profile_image;
            this.Show();
            //if (sourceForm != null)
            //{
            //    _sourceForm = sourceForm;
            //    _sourceForm.Hide();
            //    this.Show();
            //}

            
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaxiName
            // 
            this.lblTaxiName.BackColor = System.Drawing.Color.White;
            this.lblTaxiName.Font = new System.Drawing.Font("IRANYekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxiName.Location = new System.Drawing.Point(225, 36);
            this.lblTaxiName.Name = "lblTaxiName";
            this.lblTaxiName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTaxiName.Size = new System.Drawing.Size(215, 35);
            this.lblTaxiName.TabIndex = 1;
            this.lblTaxiName.Text = "تاکسی دار";
            this.lblTaxiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("IRANYekan", 8F);
            this.label1.Location = new System.Drawing.Point(1013, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "پدرام یمینی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("IRANYekan", 8F);
            this.label2.Location = new System.Drawing.Point(1159, 36);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "مدیر تاکسی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::BaseFormLibrary.Properties.Resources.Icon_awesome_arrow_left;
            this.pictureBox3.Location = new System.Drawing.Point(1267, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BaseFormLibrary.Properties.Resources.Icon_feather_camera;
            this.pictureBox2.Location = new System.Drawing.Point(1126, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.White;
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.Image = global::BaseFormLibrary.Properties.Resources.user_profile;
            this.profile.Location = new System.Drawing.Point(1113, 33);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(43, 41);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 2;
            this.profile.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BaseFormLibrary.Properties.Resources.BaseForm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 749);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.lblTaxiName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
