using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WND.Models
{
    public class Path
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        [Display(Name = "مبدا")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی می‌باشد.")]
        public string Origin { get; set; }

        [StringLength(250)]
        [Display(Name = "مقصد")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی می‌باشد.")]
        public string Destination { get; set; }

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

        [Display(Name = "هزینه")]
        [Required(ErrorMessage = "وارد کردن {0} الزامی می‌باشد.")]
        [Range(1, 10000000, ErrorMessage = "{0} باید مقداری صحیح بین 1 تومان تا 10 میلیون تومان باشد.")]
        public int Cost { get; set; }

        public virtual ICollection<Models.ServicePath> ServicePaths { get; set; }
    }
}
