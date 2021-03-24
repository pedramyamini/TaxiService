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
        public static bool ValidateFullName(string input)
        {

            if (Regex.IsMatch(input, "^[ يآابپتثجچحخدذرزژسشصضطظعغفقکگلمنوهی]{5,150}$") && input.Contains(" ") && input.Split(' ')[0].Length > 1 && input.Split(' ')[1].Length > 1)
            {
                return true;
            }
            MessageBoxRTL.Error("نام و نام خانوادگی تنها شامل حروف فارسی می‌تواند باشد و نباید کمتر از ۵ کاراکتر و شامل یک فاصله باشد", "");
            return false;
        }

        public static bool ValidateMobile(string mobile)
        {
            if (Regex.IsMatch(mobile, @"^(09)[0-9]{9}$"))
            {
                return true;
            }
            MessageBoxRTL.Error("شماره همراه باید حداکثر شامل ۱۱ رقم باشد که با ۰ آغاز می‌شود لطفا از وارد کردن کد کشور خودداری کنید.", "");
            return false;
        }

        public static bool ValidateSharePercent(string SharePercent)
        {
            if (Regex.IsMatch(SharePercent, @"^[0-9]{1,3}$") && int.Parse(SharePercent)<=100)
            {
                return true;
            }
            MessageBoxRTL.Error("درصد اشتراک به صورت عدد و تنها در بازه ۰ تا ۱۰۰ می‌باشد لطفا ورودی را بررسی کنید", "");
            return false;
        }

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
