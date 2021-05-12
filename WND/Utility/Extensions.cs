using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Utility
{
    public static class Extensions
    {
        private static string[] Days = { "یک شنبه", "دو شنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه", "شنبه" };
        private static string[] Months = { "فروردین", "اریبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
        private static PersianCalendar pc = new PersianCalendar();

        public static string ToPersianDateString(this DateTime englishDate)
        {
            return $"{Days[pc.GetDayOfWeek(englishDate).GetHashCode()]} {pc.GetDayOfMonth(englishDate)} {Months[pc.GetMonth(englishDate) - 1]} {pc.GetYear(englishDate)}";
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