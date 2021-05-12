using BaseFormLibrary;
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
    public partial class SecretaryPanel : BaseForm
    {
        public SecretaryPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.MessageBoxRTL.Ask("آیا از خروج از حساب کاربری اطمینان دارید؟", "هشدار") == DialogResult.Yes)
            {
                Session.CurrentUser = null;
                this.Close();
            }

        }

        private void SecretaryPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            new AddCustomer();
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            new AddService();
        }

        private void EditService_Click(object sender, EventArgs e)
        {
            new EditService();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureboxEditCustomer_Click(object sender, EventArgs e)
        {

        }

        private void pictureboxAddCustomer_Click(object sender, EventArgs e)
        {
            new AddCustomer();
        }

        private void pictureboxAddService_Click(object sender, EventArgs e)
        {
            new AddService();
        }

        private void pictureboxEditService_Click(object sender, EventArgs e)
        {
            new EditService();
        }
    }
}
