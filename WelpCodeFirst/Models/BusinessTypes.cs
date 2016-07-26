using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class BusinessTypes
    {
        //proterties
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string BusinessTypeName { get; set; }

        //navagation properties
        public virtual ICollection<Businesses> Businesses { get; set; }
    }
}