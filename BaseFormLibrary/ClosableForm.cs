using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BaseFormLibrary
{
    public class ClosableForm:Form
    {
        
        public ClosableForm()
        {
            //this.Size = new System.Drawing.Size(1386,768);
            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
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
    }
}
