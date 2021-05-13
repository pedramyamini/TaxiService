using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AuthenticatedUser : User
    {
        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0} باید بین 6 تا 20 کاراکتر باشد")]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        
        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings =false,ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string Password { get; set; }

        [Display(Name ="سوال امنیتی")]
        [Required(AllowEmptyStrings =true,ErrorMessage ="{0} نمی‌تواند خالی باشد.")]
        public string SecurityQuestion { get; set; }

        [Display(Name = "پاسخ امنیتی")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string SecurityAnswer { get; set; }

        [Display(Name = "نام تاکسی تلفنی")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string TaxiName { get; set; } = "تاکسی دار";
    }
}
