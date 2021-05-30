using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace BaseFormLibrary
{
    public class RegisterForm:Form
    {
        public PictureBox btnContactUs;
        public PictureBox checkboxTogglePasswordDisplay;
        public TextBox txtUsername;
        public TextBox txtPassword;
        public PictureBox btnReset;
        public Label lbl1;
        public Label btnRestorePassword;
        public PictureBox btnExit;
        public PictureBox btnLogin;
        public PictureBox pictureBox1;
        
        public RegisterForm()
        {
            this.Size = new System.Drawing.Size(1386,768);
            this.WindowState = FormWindowState.Maximized;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
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
            this.SuspendLayout();
            // 
            // RegisterForm
            // 
            this.BackgroundImage = global::BaseFormLibrary.Properties.Resources.Sign_Up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.ResumeLayout(false);

        }
    }
}
