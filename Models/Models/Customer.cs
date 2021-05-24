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
    public class Customer:User,ICloneable
    {
        [DisplayName("نشانی")]
        [Display(Name ="نشانی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد کردن {0} ضروری است")]
        public string Address { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public object Clone()
        {
            if (this.GetType().IsSerializable)
            {
                return this.CopyObject<Customer>();
            }
            return null;
        }
    }
}
