using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Models
{
    
    public class Driver:User
    {
        public int SharePercent { get; set; }

        [Required]
        public virtual Car Car { get; set; }

    }
}
