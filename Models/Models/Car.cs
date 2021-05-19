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
    
    public class Car
    {
        [Key, ForeignKey("Driver")]
        public int Id { get; set; }

        [DisplayName("مدل")]
        [Display(Name = "مدل")]
        [Required(AllowEmptyStrings =true,ErrorMessage ="{0} نمی‌تواند خالی باشد.")]
        public string Model { get; set; }
        
        public string LicensePlate { get; set; }

        [DisplayName("رنگ")]
        [Display(Name = "رنگ")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string Color { get; set; }

        [Required]
        public virtual Driver Driver { get; set; }
    }
}
