using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class AuthenticatedUser : User , ICloneable
    {
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} باید بین 6 تا 20 کاراکتر باشد")]
        [DisplayName("نام کاربری")]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        
        [DisplayName("کلمه عبور")]
        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings =false,ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string Password { get; set; }

        [DisplayName("سوال امنیتی")]
        [Display(Name = "سوال امنیتی")]
        [Required(AllowEmptyStrings =true,ErrorMessage ="{0} نمی‌تواند خالی باشد.")]
        public string SecurityQuestion { get; set; }

        [DisplayName("پاسخ امنیتی")]
        [Display(Name = "پاسخ امنیتی")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string SecurityAnswer { get; set; }

        [DisplayName("نام تاکسی تلفنی")]
        [Display(Name = "نام تاکسی تلفنی")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string TaxiName { get; set; } = "تاکسی دار";


        public object Clone()
        {
            if (this.GetType().IsSerializable)
            {
                return this.CopyObject<AuthenticatedUser>();
            }
            return null;
        }
    }
}
