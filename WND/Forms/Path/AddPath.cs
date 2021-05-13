using BaseFormLibrary;
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
using Utility;


namespace WND.Path
{
    public partial class AddPath : BaseForm
    {
        public AddPath()
        {
            InitializeComponent();
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
                    if(!TaxiDbContext.Instance.Paths.Any(p=>p.OriginDestination==path.OriginDestination))
                    {
                        TaxiDbContext.Instance.Paths.Add(path);
                        TaxiDbContext.Instance.SaveChanges();
                        MessageBoxRTL.Info("افزودن مسیر با موفقیت انجام شد.", "");
                    }
                    else
                    {
                        DialogResult dr;
                        dr = MessageBoxRTL.Ask("این مسیر قبلا ثبت شده است. آیا تمایل به ویرایش آن دارید؟", "");
                        if (dr == DialogResult.Yes)
                        {
                            try
                            {
                                Models.Path existingPath = TaxiDbContext.Instance.Paths.Where(p => p.OriginDestination == path.OriginDestination)
                                .Select(p => p).Single();
                                TaxiDbContext.Instance.Paths.Attach(existingPath);
                                existingPath.OriginDestination = path.OriginDestination;
                                existingPath.Origin = path.Origin;
                                existingPath.Destination = path.Destination;
                                existingPath.Cost = path.Cost;
                                TaxiDbContext.Instance.SaveChanges();
                                MessageBoxRTL.Info("ویرایش مسیر با موفقیت انجام شد.", "");
                                return;
                            }
                            catch
                            {
                                MessageBoxRTL.Info("ویرایش مسیر با خطا روبرو شد لطفا دوباره تلاش نمایید.", "");
                            }
                        }
                    }
                }
                catch
                {
                    
                    MessageBoxRTL.Info("افزودن مسیر با خطا روبرو شد لطفا دوباره تلاش نمایید.", "");
                }
            }
        }

        private void AddPath_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void AddPath_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBoxRTL.Ask("آیا از خروج اطمینان دارید؟", "");
            if (dr == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
