using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Call_SMS;
using WND.Data;
using WND.Report;
using WND.Utility;

namespace WND
{
    static class Program
    {
        private static TaxiDbContext taxiContext = new TaxiDbContext();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!taxiContext.AuthenticatedUsers.Any())
            {
                MessageBoxRTL.Info("کاربر گرامی به نرم‌افزار مدیریت تاکسی تلفنی خوش آمدید. لطفا نام کاربری و کلمه عبور مدیر را جهت ثبت نام وارد نمایید", "خوش‌آمدگویی");
                Application.Run(new Register());
            }
            else
            {
                Application.Run(new Login());
            }

        }
    }
}
