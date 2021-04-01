using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Models
{
    public class Service
    {
        public int Id { get; set; }

        
        public string OriginInDetail { get; set; }

        public string DestinationInDetail { get; set; }

        public DateTime DateTime { get; set; }

        public int Delay { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(Models.Customer))]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "{0} ضروری است.")]
        [Display(Name = "مشتری")]
        public virtual Customer Customer { get; set; }

        [ForeignKey(nameof(Models.Driver))]
        public int DriverId { get; set; }
        
        [Required(ErrorMessage ="{0} ضروری است.")]
        [Display(Name ="راننده")]
        public virtual Driver Driver { get; set; }


        [Required(ErrorMessage = "{0} ضروری است.")]
        [Display(Name = "تراکنش")]
        public virtual Transaction Transaction { get; set; }

        public bool IsDeleted { get; set; }

        [Required(ErrorMessage = "{0} ضروری است.")]
        [Display(Name = "مسیر")]
        public virtual ICollection<Models.ServicePath> ServicePaths { get; set; }
    }
}
