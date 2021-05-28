using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public static class LicensePlateCalculation
    {
        //public static string CalculateLicensePlate(List<TextBox> LPtextBoxes)
        //{
        //    string LicensePlate = string.Empty;
        //    LPtextBoxes.ForEach(t => LicensePlate += t.Text.Trim() + "-");
        //    LicensePlate = LicensePlate.Substring(0, LicensePlate.Length - 1);
        //    return LicensePlate;
        //}


        public static bool IsCompelete(Models.Car car)
        {
            if(!string.IsNullOrEmpty(car.LicensePlate1) && car.LicensePlate1.Length ==2 &&
               !string.IsNullOrEmpty(car.LicensePlate2) && car.LicensePlate2.Length == 1 &&
               !string.IsNullOrEmpty(car.LicensePlate3) && car.LicensePlate3.Length == 3 &&
               !string.IsNullOrEmpty(car.LicensePlate4) && car.LicensePlate4.Length == 2)
            {
                List<char> ValidAlphabets = "تجدسصطقبژلمنوهیتجدسصطقبژلمنوهی".ToCharArray().ToList();
                if (!ValidAlphabets.Contains(car.LicensePlate2.ToCharArray()[0]))
                {
                    MessageBoxRTL.Error(" \nحرف پلاک در محدوده حروف مجاز قرار ندارد. "
                        + "حروف مجاز :  ت،ج،د،س،ص،ط،ق،ب،ژ،ل،م،ن،و،ه،ی"
                        , string.Empty);
                    return false;
                }    
                return true;
            }
            else
            {
                MessageBoxRTL.Error("پلاک خودرو ضروری است و از چپ به راست شامل 2 رقم، یک حرف، 3 رقم و 2 رقم می‌باشد.", string.Empty);
                return false;
            }
        }
    }
}
