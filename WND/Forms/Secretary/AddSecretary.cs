using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using WND.Models;
using WND.Utility;

namespace WND.Secretary
{
    public partial class AddSecretary : Form
    {
        private ITaxiDbContext taxiContext;
        Form sourceForm;
        
        public AddSecretary(ITaxiDbContext _taxiContext)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
        }

        public AddSecretary(ITaxiDbContext _taxiContext,Form _sourceForm)
        {
            InitializeComponent();
            this.taxiContext = _taxiContext;
            this.sourceForm = _sourceForm;
        }

        private void AddSecretary_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            try
            {
                Models.AuthenticatedUser secretary = new AuthenticatedUser()
                {
                    FullName = txtFullName.Text,
                    Username = txtUsername.Text,
                    Password = EasyHash.Hash(txtPassword.Text),
                    Mobile = txtMobile.Text.PersianToEnglish(),
                    Role = Roles.Secretary,
                    SecurityQuestion = string.Empty,
                    SecurityAnswer = string.Empty
                };
                if (Validation.Validate(secretary))
                {
                    taxiContext.AuthenticatedUsers.Add(secretary);
                    taxiContext.SaveChanges();
                    MessageBoxRTL.Info("منشی با موفقیت افزوده شد.", "");
                }
            }
            catch (DbUpdateException ex)
            {
                if (ex != null)
                {
                    MessageBoxRTL.Error("شماره همراه نمی‌تواند تکراری باشد", "");
                }
                else
                {
                    MessageBoxRTL.Error("افزودن منشی با خطا مواجه شد لطفا دوباره تلاش کنید", "");
                }
            }
        }

        private void AddSecretary_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void AddSecretary_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {
                sourceForm.Enabled = true;
                sourceForm.Focus();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
