using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WND.Utility
{
    public static class Validation
    {
        public static bool ValidatePassword(string password)
        {
            if(password.Count(p=>char.IsDigit(p))>=1 
                && password.Count(p=>char.IsLower(p))>=1
                && password.Count(p=>char.IsUpper(p))>=1
                && password.Length>=8)
            {
                return true;
            }
            else
            {
                MessageBoxRTL.Error("کلمه عبور باید حداقل 8 کاراکتر باشد شامل حداقل یک حرف کوچک، یک حرف بزرگ، یک رقم و یک نماد","");
                return false;
            }
        }
    }
}
