using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using WND.Forms.Customer;
using WND.Utility;

namespace WND
{
    public partial class SecretaryPanel : Form
    {
        private ITaxiDbContext taxiContext;
        Form sourceForm;
        public SecretaryPanel(ITaxiDbContext _taxiContext, Form _sourceForm)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
            sourceForm = _sourceForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBoxRTL.Ask("آیا از خروج از حساب کاربری اطمینان دارید؟", "هشدار") == DialogResult.Yes)
            {
                Session.CurrentUser = null;
                this.Close();
            }

        }

        private void SecretaryPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            sourceForm.Enabled = true;
            sourceForm.Show();
            sourceForm.Focus();
        }

        private void SecretaryPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            new AddCustomer(taxiContext,this).Show();
            this.Enabled = false;
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            new AddService(taxiContext, this).Show();
            this.Enabled = false;
        }

        private void EditService_Click(object sender, EventArgs e)
        {
            new EditService(taxiContext, this).Show();
            this.Enabled = false;
        }
    }
}
