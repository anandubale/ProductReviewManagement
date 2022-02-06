using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace LinqDemo
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReviews> listproductReviews)
        {
            var recordedData = (from productReviews in listproductReviews
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine($"ProductID:- {list.ProductID} UserID:- {list.UserID} Rating:-{list.Rating} Reviews:- {list.Reviews} isLike:- {list.isLike}");
            }
        }

        public void selectedRecords(List<ProductReviews> listproductReviews)
        {
            var recordedData = from productReviews in listproductReviews
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9
                               && productReviews.Rating > 3)
                               select productReviews;


            foreach (var list in recordedData)
            {
                Console.WriteLine($"ProductID:- {list.ProductID} UserID:- {list.UserID} Rating:-{list.Rating} Reviews:- {list.Reviews} isLike:- {list.isLike}");
            }
        }



        public void RetrieveCountOfRecords(List<ProductReviews> listproductReviews)
        {
            var recordedData = listproductReviews.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, count = x.Count() });

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "-----" + list.count);
            }
        }

        public void RetrieveProductID(List<ProductReviews> listProductReview)
        {
            var recordedData = (from list in listProductReview
                                select new { list.ProductID, list.Reviews });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ToString());
            }

        }
        public void SkipTopFive(List<ProductReviews> listProductReview)
        {
            var recordedData = (from list in listProductReview
                                orderby list.Rating descending
                                select list);
            foreach (var element in recordedData.Skip(5))
            {
                Console.WriteLine(element.ToString());
            }

        }


    }
}
