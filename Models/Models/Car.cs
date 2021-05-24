using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Car: ICloneable
    {
        [Key, ForeignKey("Driver")]
        public int Id { get; set; }

        [DisplayName("مدل")]
        [Display(Name = "مدل")]
        [Required(AllowEmptyStrings =true,ErrorMessage ="{0} نمی‌تواند خالی باشد.")]
        public string Model { get; set; }
        
        [RegularExpression("^[0-9]{2}$", ErrorMessage ="دو رقم ابتدایی پلاک از چپ صحیح نیست")]
        public string LicensePlate1 { get; set; }

        [RegularExpression("^[0-9]{3}$", ErrorMessage = "سه رقم میانی پلاک نیست")]
        public string LicensePlate3 { get; set; }

        [RegularExpression("^[0-9]{2}$", ErrorMessage = "دو رقم انتهایی پلاک از راست صحیح نیست")]
        public string LicensePlate4 { get; set; }


        [RegularExpression("^[تجدسصطقعلمنوهیتجدسصطقعلمنوهی]{1}$", ErrorMessage ="حرف پلاک از محدوده حروف مجاز خارج است")]
        public string LicensePlate2 { get; set; }

        [DisplayName("رنگ")]
        [Display(Name = "رنگ")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string Color { get; set; }

        [Required]
        public virtual Driver Driver { get; set; }

        public object Clone()
        {
            if (this.GetType().IsSerializable)
            {
                return this.CopyObject<Car>();
            }
            return null;
        }
    }
}
