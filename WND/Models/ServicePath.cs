using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Models
{
    public class ServicePath
    {
        [Key]

        public int Id { get; set; }

        [ForeignKey(nameof(Models.Service))]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        [ForeignKey(nameof(Models.Path))]
        public  int PathId { get; set; }

        public virtual Path Path { get; set; }
    }
}
