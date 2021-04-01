using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Models
{
    
    public class Car
    {
        [Key, ForeignKey("Driver")]
        public int Id { get; set; }

        [Display(Name ="مدل")]
        [Required(AllowEmptyStrings =true,ErrorMessage ="{0} نمی‌تواند خالی باشد.")]
        public string Model { get; set; }
        
        public string LicensePlate { get; set; }

        [Display(Name = "رنگ")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "{0} نمی‌تواند خالی باشد.")]
        public string Color { get; set; }

        [Required]
        public virtual Driver Driver { get; set; }
    }
}
