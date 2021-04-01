using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WND.Utility
{
    public static class Validation
    {
        public static bool Validate(object toValidate)
        {
            ValidationContext context = new ValidationContext(toValidate, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(toValidate, context, errors, true))
            {
                string ErrorMessage=string.Empty;
                foreach (ValidationResult result in errors)
                    ErrorMessage += "\n " + result.ErrorMessage;
                MessageBoxRTL.Error(ErrorMessage,string.Empty);
                return false;
            }
            return true;
        }
        
        
        
        public static bool ValidatePassword(string password)
        {
            if (password.Count(p => char.IsDigit(p)) >= 1
                && password.Count(p => char.IsLower(p)) >= 1
                && password.Count(p => char.IsUpper(p)) >= 1
                && password.Length >= 8)
            {
                return true;
            }
            else
            {
                MessageBoxRTL.Error("کلمه عبور باید حداقل 8 کاراکتر باشد شامل حداقل یک حرف کوچک، یک حرف بزرگ، یک رقم و یک نماد", "");
                return false;
            }
        }


        //extension method for string to convert persian numbers to english
        public static string PersianToEnglish(this string persianStr)
        {

            persianStr = persianStr.Trim();
            Dictionary<char, char> LettersDictionary = new Dictionary<char, char>
            {
                ['۰'] = '0',
                ['۱'] = '1',
                ['۲'] = '2',
                ['۳'] = '3',
                ['۴'] = '4',
                ['۵'] = '5',
                ['۶'] = '6',
                ['۷'] = '7',
                ['۸'] = '8',
                ['۹'] = '9'
            };
            foreach (var item in persianStr)
            {
                try
                {
                    persianStr = persianStr.Replace(item, LettersDictionary[item]);
                }
                catch
                {

                }
            }
            return persianStr;
        }
    }
}
