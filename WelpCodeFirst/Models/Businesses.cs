﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Businesses
    {
        //proterties
        public int BusinessID { get; set; }
        [MaxLength(50)]
        public string BusinessName { get; set; }
        public int BusinessTypeID { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Hours { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        public string Menu { get; set; }
        public int UserID { get; set; }


        //navagation properties
        public virtual BusinessTypes BusinessType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
    }
}