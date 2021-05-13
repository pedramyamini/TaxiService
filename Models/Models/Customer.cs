using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer:User
    {
        [Display(Name = "نشانی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد کردن {0} ضروری است")]
        public string Address { get; set; }

        public virtual ICollection<Models.Service> Services { get; set; }
    }
}
