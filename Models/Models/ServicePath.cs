using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class ServicePath:ICloneable
    {
        [Key]

        public int Id { get; set; }

        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        [ForeignKey(nameof(Path))]
        public  int PathId { get; set; }

        public virtual Path Path { get; set; }

        public object Clone()
        {
            if (this.GetType().IsSerializable)
            {
                return this.CopyObject<Driver>();
            }
            return null;
        }
    }
}
