using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
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

        public static void ChangeMenuItemImage(this Button btn,Image image)
        {
            btn.FlatAppearance.BorderSize = 0;
            btn.BackgroundImage = image;
            btn.Width = 180;
            btn.Height = 67;
            btn.ForeColor = Color.FromArgb(255, 178, 55);
            btn.BackColor = Color.FromArgb(242, 242, 242);
            btn.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(242, 242, 242);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            
            btn.Refresh();
        }

        public static T CopyObject<T>(this object objSource)

        {

            using (MemoryStream stream = new MemoryStream())

            {

                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, objSource);

                stream.Position = 0;

                return (T)formatter.Deserialize(stream);

            }

        }

    }
}