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
    public class Transaction:ICloneable
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

        public object Clone()
        {
            if (this.GetType().IsSerializable)
            {
                return this.CopyObject<Transaction>();
            }
            return null;
        }
    }
}
