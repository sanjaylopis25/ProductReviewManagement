using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class Management
    {
        //UC1
        public void TopRecords(List<Productreview> productreviewlist)
        {
            var recorddata = (from Productreview in productreviewlist
                              orderby
Productreview.rating descending
                              select Productreview).Take(3);
            foreach (var item in recorddata)
            {
                Console.Write($"\n\nproductid= {item.productid}\nuserid= {item.userid}\nrating= {item.rating}\nreview= {item.review}\nisLike= {item.islike}");

            }

        }
        //UC2
        public void selectrecords(List<Productreview> productreviewlist)
        {
            var recorddata = (from productreview in productreviewlist
                              where (productreview.productid > 3 && productreview.rating == 3 ||
productreview.productid > 3 && productreview.rating == 4 || productreview.productid > 3 && productreview.rating == 9)
                              select productreview);
            foreach (var item in recorddata)
            {
                Console.Write($"\n\nproductid= {item.productid}\nuserid= {item.userid}\nrating= {item.rating}\nreview= {item.review}\nisLike= {item.islike}");

            }

        }
    }
}
