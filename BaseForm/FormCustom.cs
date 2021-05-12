using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;

namespace WND.Utility
{
    public class FormCustom:Form
    {
        private FormCustom _sourceForm;

        public FormCustom()
        {

        }
        public FormCustom(FormCustom sourceForm)
        {
            this.WindowState = FormWindowState.Maximized;
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            if (sourceForm != null)
            {
                _sourceForm = sourceForm;
                _sourceForm.Hide();
                this.Show();
            }

            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {   
                if(_sourceForm!=null)
                {
                    _sourceForm.Show();
                    _sourceForm.Focus();
                }
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
            // FormCustom
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormCustom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }
    }
}
