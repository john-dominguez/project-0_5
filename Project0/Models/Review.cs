using System;
using System.Collections.Generic;

namespace RestaurantApp.Models
{
    public class Review
    {
        public int Rating { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Review(int rating, string name)
        {
            Name = name;
            Rating = rating;
            Date = DateTime.Now;
        }

        public static List<Review> MakeReviews()
        {
           return new List<Review>()
            {
                new Review(7, "John"),
                new Review(5, "Jake"),
                new Review(9, "Franky"),
                new Review(6, "Manny")
            };
        }
    }
}