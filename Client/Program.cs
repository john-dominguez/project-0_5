using System;
using DataLayer;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantCrud crud = new RestaurantCrud();
            crud.TestDbConnection();

            foreach (var restaurant in crud.GetRestaurants())
            {
                Console.WriteLine(restaurant.name);
            }

            Console.ReadLine();
        }
    }
}
