using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    public class Productreview
    {
        public int productid { get; set; }
        public int userid { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool islike { get; set; }
    }
}
