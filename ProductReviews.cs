using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class ProductReviews
    {   
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public  double Rating { get; set; }
        public string Reviews { get; set; }
        public bool isLike { get; set; }
    }
}
