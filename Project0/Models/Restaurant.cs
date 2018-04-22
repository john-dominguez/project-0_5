using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Review> Reviews { get; set; }

        public Restaurant(int id, string name, List<Review> reviews)
        {
            Id = id;
            Name = name;
            Reviews = reviews;
        }

        public double AverageRating()
        {
            return Reviews.Sum(x => x.Rating) / Reviews.Count;
        }

        public static List<Restaurant> MakeRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant(1, "ShitBee's", Review.MakeReviews()),
                new Restaurant(2, "KillDonald's", Review.MakeReviews()),
                new Restaurant(3, "Papa Smurf's", Review.MakeReviews()),
                new Restaurant(4, "OliveDump", Review.MakeReviews()),
            };
            return restaurants;
        }
    }
   
}