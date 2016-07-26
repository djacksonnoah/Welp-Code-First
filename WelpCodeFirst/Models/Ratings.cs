using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class Ratings
    {
        //proterties
        public int RatingID { get; set; }
        public int UserName { get; set; }
        public int BusinessID { get; set; }
        public short? StarReview { get; set; }
        public string TextReview { get; set; }

        //navagation properties
        public virtual User User { get; set; }
        public virtual Businesses Business { get; set; }
    }
}