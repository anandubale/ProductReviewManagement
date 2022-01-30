using System;
using System.Collections.Generic;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //LinqToDataTableDemo linqToDataTableDemo = new LinqToDataTableDemo();
            //linqToDataTableDemo.AddtotableDataDemo();



            Console.WriteLine("welcome to project  Review management Problem statement");


            List<ProductReviews> productReviewsList = new List<ProductReviews>()
            {

                new ProductReviews() { ProductID = 1, UserID = 1, Rating = 5, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 2, UserID = 1, Rating = 4, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 3, UserID = 2, Rating = 5, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 4, UserID = 2, Rating = 5, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 5, UserID = 3, Rating = 3, Reviews = "nice", isLike = false },
                new ProductReviews() { ProductID = 6, UserID = 3, Rating = 2, Reviews = "nice", isLike = true },
                new ProductReviews() { ProductID = 7, UserID = 4, Rating = 5, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 8, UserID = 4, Rating = 1, Reviews = "Bad", isLike = false },
                new ProductReviews() { ProductID = 9, UserID = 10, Rating = 2, Reviews = "Bad", isLike = false },
                new ProductReviews() { ProductID = 10, UserID = 10, Rating = 5, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 11, UserID = 6, Rating = 5, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 12, UserID = 6, Rating = 4, Reviews = "Good", isLike = true },
                new ProductReviews() { ProductID = 13, UserID = 7, Rating = 3, Reviews = "nice", isLike = false },
                new ProductReviews() { ProductID = 14, UserID = 7, Rating = 5, Reviews = "Good", isLike = true }

            };
            // UC1
            //foreach (var list in productReviewsList)
            //{
            //    Console.WriteLine($"ProductID:- {list.ProductID} UserID:- {list.UserID} Rating:-{list.Rating} Reviews:- {list.Reviews} isLike:- {list.isLike}");
            //}



            Management management = new Management();
            //UC2
            //management.TopRecords(productReviewsList);


            //UC3
            //management.selectedRecords(productReviewsList);

            //UC4
            management.RetrieveCountOfRecords(productReviewsList);


        }
    }
}
