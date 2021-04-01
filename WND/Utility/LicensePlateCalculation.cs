using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WND.Utility
{
    public static class LicensePlateCalculation
    {
        public static string CalculateLicensePlate(List<TextBox> LPtextBoxes)
        {
            string LicensePlate = string.Empty;
            LPtextBoxes.ForEach(t => LicensePlate += t.Text.Trim() + "-");
            LicensePlate = LicensePlate.Substring(0, LicensePlate.Length - 1);
            return LicensePlate;
        }
    }
}
