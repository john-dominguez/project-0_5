using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestaurantCrud
    {
        private RestaurantDBContext _db = new RestaurantDBContext();

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return _db.Restaurants;
        }

        public Restaurant GetRestaurant(int id)
        {
            return _db.Restaurants.Find(id);
        }

        public bool CreatetRestaurant(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateRestaurant(Restaurant restaurant)
        {
            _db.Restaurants.AddOrUpdate(restaurant);
            _db.SaveChanges();
            return true;
        }

        public void DeleteRestaurant(int id)
        {
            Restaurant restaurant = _db.Restaurants.Find(id);
            if (restaurant != null)
            {
                _db.Restaurants.Remove(restaurant);
                _db.SaveChanges();
            }
        }

        //Review
        public Review GetReview(int id)
        {
            return _db.Reviews.Find(id);
        }

        public bool CreatetReview(Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateReview(Review review)
        {
            _db.Reviews.AddOrUpdate(review);
            _db.SaveChanges();
            return true;
        }

        public void DeleteReview(int id)
        {
            Review review = _db.Reviews.Find(id);
            if (review != null)
            {
                _db.Reviews.Remove(review);
                _db.SaveChanges();
            }

        }

        public void TestDbConnection()
        {
            Console.WriteLine(_db.Database.Connection.ConnectionString);
        }
    }
}
