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
            if(!string.IsNullOrEmpty(car.LicensePlate1) &&
               !string.IsNullOrEmpty(car.LicensePlate2) &&
               !string.IsNullOrEmpty(car.LicensePlate3) &&
               !string.IsNullOrEmpty(car.LicensePlate4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
