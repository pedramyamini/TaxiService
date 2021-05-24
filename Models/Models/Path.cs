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
    public class Path:ICloneable
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        [DisplayName("مبدا")]
        [Display(Name = "مبدا")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی می‌باشد.")]
        public string Origin { get; set; }

        [StringLength(250)]
        [DisplayName("مقصد")]
        [Display(Name = "مقصد")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی می‌باشد.")]
        public string Destination { get; set; }

        [DisplayName("مسیر")]
        [Display(Name = "مسیر")]
        public string OriginDestination
        {
            get
            {
                if (!string.IsNullOrEmpty(Origin) && !string.IsNullOrEmpty(Destination))
                {
                    return $"{Origin} - {Destination}";
                }
                return string.Empty;
            }
            set { }
        }

        [DisplayName("هزینه")]
        [Display(Name = "هزینه")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی می‌باشد.")]
        [Range(1, 10000000, ErrorMessage = "{0} باید مقداری صحیح بین 1 تومان تا 10 میلیون تومان باشد.")]
        public int Cost { get; set; }

        public virtual ICollection<ServicePath> ServicePaths { get; set; }

        public object Clone()
        {
            if (this.GetType().IsSerializable)
            {
                return this.CopyObject<Path>();
            }
            return null;
        }

        public bool IsDeleted { get; set; } = false;
    }
}
