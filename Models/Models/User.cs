﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(AllowEmptyStrings =false,ErrorMessage = "وارد کردن {0} ضروری است")]
        public string FullName { get; set; }

        [StringLength(11)]
        [Index(IsUnique = true,IsClustered =false)]
        [Display(Name = "شماره همراه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد کردن {0} ضروری است")]
        [RegularExpression("^(09)[0-9]{9}$", ErrorMessage ="{0} باید 11 رقم باشد و با 09 شروع شود")]
        public string Mobile { get; set; }

        public Roles Role { get; set; }

    }
}