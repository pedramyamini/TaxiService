using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Data;
using WND.Utility;

namespace WND.Path
{
    public partial class AddPath : Form
    {
        private ITaxiDbContext taxiContext;
        Form sourceForm;
        public AddPath(ITaxiDbContext _taxiContext)
        {
            InitializeComponent();
            taxiContext = _taxiContext;
        }

        public AddPath(ITaxiDbContext _taxiContext, Form _sourceForm)
        {
            InitializeComponent();
            taxiContext = _taxiContext;
            sourceForm = _sourceForm;
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            int Cost = 0;
            int.TryParse(txtCost.Text.Trim().PersianToEnglish(), out Cost);
            Models.Path path = new Models.Path()
            {
                Origin = txtOrigin.Text.Trim(),
                Destination = txtDestination.Text.Trim(),
                Cost = Cost
            };
            if (Validation.Validate(path))
            {
                try
                {
                    taxiContext.Paths.AddOrUpdate(path);
                    taxiContext.SaveChanges();
                    MessageBoxRTL.Info("افزودن مسیر با موفقیت انجام شد.", "");
                }
                catch(DbUpdateException ex)
                {
                    if(ex!=null)
                    {
                        DialogResult dr;
                        dr=MessageBoxRTL.Ask("این مسیر قبلا ثبت شده است. آیا تمایل به ویرایش آن دارید؟", "");
                        if(dr==DialogResult.Yes)
                        {
                            try
                            {
                                Models.Path existingPath = taxiContext.Paths.Where(p => p.OriginDestination == path.OriginDestination)
                                .Select(p => p).Single();
                                taxiContext.Paths.Remove(existingPath);
                                taxiContext.Paths.Add(path);
                                taxiContext.SaveChanges();
                                MessageBoxRTL.Info("ویرایش مسیر با موفقیت انجام شد.", "");
                            }
                            catch
                            {
                                MessageBoxRTL.Info("ویرایش مسیر با خطا روبرو شد لطفا دوباره تلاش نمایید.", "");
                            }
                        }
                    }
                    else
                    {
                        MessageBoxRTL.Info("افزودن مسیر با خطا روبرو شد لطفا دوباره تلاش نمایید.", "");
                    }
                }
            }
        }

        private void AddPath_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {
                sourceForm.Enabled = true;
                sourceForm.Focus();
            }
        }
    }
}
