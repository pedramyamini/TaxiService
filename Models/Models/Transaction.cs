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
    public class Transaction
    {
        
        [Key,ForeignKey("Service")]
        public int Id { get; set; }

        [DisplayName("هزینه")]
        [Display(Name = "هزینه")]
        public int Amount { get; set; }

        [DisplayName("پرداخت شده")]
        [Display(Name = "پرداخت شده")]
        public bool IsPaid { get; set; }

        public virtual Service Service { get; set; }
    }
}
