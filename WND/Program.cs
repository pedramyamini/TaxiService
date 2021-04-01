using Ninject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WND.Call_SMS;
using WND.Data;
using WND.DI.Ninject;
using WND.Report;
using WND.Utility;

namespace WND
{
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.CurrentCulture = new CultureInfo("fa-IR");

            var taxiContext= DependencyInjection<ITaxiDbContext>.GetDependency();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Register or Login
            using(TaxiDbContext taxiDb=new TaxiDbContext())
            {
                if (!taxiContext.AuthenticatedUsers.Any())
                {
                    Utility.Session.RecentlyRegisteredAdmin = true;
                    MessageBoxRTL.Info("کاربر گرامی به نرم‌افزار مدیریت تاکسی تلفنی خوش آمدید. لطفا نام کاربری و کلمه عبور مدیر را جهت ثبت نام وارد نمایید", "خوش‌آمدگویی");
                    Application.Run(new Register(taxiContext));

                }
                else
                {
                    Application.Run(new Login(taxiContext));
                }
            }
            
        }
    }
}
