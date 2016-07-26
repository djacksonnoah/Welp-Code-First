using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class User
    {
        //proterties
        public int UserID { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }

        //navagation properties
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Businesses> Businesses { get; set; }
    }
}