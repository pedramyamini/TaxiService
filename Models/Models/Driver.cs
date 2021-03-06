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
    public class Driver:User,ICloneable
    {
        [Display(Name = "حق اشتراک")]
        [DisplayName("حق اشتراک")]
        [Range(1,100,ErrorMessage = "{0} باید عددی صحیح بین 1 تا 100 باشد")]
        public int SharePercent { get; set; }


        public virtual Car Car { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public object Clone()
        {
            if(this.GetType().IsSerializable)
            {
                return this.CopyObject<Driver>();
            }
            return null;
        }

    }
}
