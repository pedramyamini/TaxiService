using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WND.Models.ViewModels
{
    public class VMService
    {
        
        [DisplayName("#"),Display(Order =0)]
        public int Id { get; set; }
        
        [DisplayName("مشتری")]
        public string CustomerFullName { get; set; }

        [DisplayName("شماره همراه")]
        public string CustomerMobile { get; set; }

        [DisplayName("مسیر")]
        public string Path { get; set; }

        [DisplayName("راننده")]
        public string DriverFullName { get; set; }

        [DisplayName("شماره همراه")]
        public string DriverMobile { get; set; }

        [DisplayName("هزینه")]
        public int Cost { get; set; }

        [DisplayName("پرداخت شده")]
        public bool IsPaid { get; set; }

        [DisplayName("تاریخ و زمان")]
        public DateTime DateTime { get; set; }




    }
}
