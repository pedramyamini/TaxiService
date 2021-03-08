using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Utility;

namespace WND
{
    public partial class SecretaryPanel : Form
    {
        public SecretaryPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Service' table. You can move, or remove it, as needed.
            //this.serviceTableAdapter.Fill(this.taxiDataSet.Service);

        }

        private void btnLogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBoxRTL.Ask("آیا از خروج از حساب کاربری اطمینان دارید؟", "هشدار") == DialogResult.Yes)
            {
                this.Close();
                Session.CurrentUser = null;
                new Login().Show();
            }

        }

        private void SecretaryPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SecretaryPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBoxRTL.Ask("آیا از خروج کامل از برنامه اطمینان دارید؟", "هشدار") == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
