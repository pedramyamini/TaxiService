using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    [Serializable]
    public class User:ICloneable
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("نام و نام خانوادگی")]
        [Display(Name = "نام و نام خانوادگی")]
        [Required(AllowEmptyStrings =false,ErrorMessage = "وارد کردن {0} ضروری است")]
        public string FullName { get; set; }

        [StringLength(11)]
        [Index(IsUnique = false,IsClustered =false)]
        [DisplayName("شماره همراه")]
        [Display(Name = "شماره همراه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد کردن {0} ضروری است")]
        [RegularExpression("^(09)[0-9]{9}$", ErrorMessage ="{0} باید 11 رقم باشد و با 09 شروع شود")]
        public string Mobile { get; set; }

        public Roles Role { get; set; }

        public bool IsDeleted { get; set; } = false;



        [DisplayName("تاریخ عضویت")]
        [Display(Name = "تاریخ عضویت")]
        public DateTime DateJoined { get; set; }

        public object Clone()
        {
            if (this.GetType().IsSerializable)
            {
                return this.CopyObject<User>();
            }
            return null;
        }
    }
}
