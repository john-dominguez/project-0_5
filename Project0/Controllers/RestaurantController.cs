using System;
using System.Linq;
using System.Web.Mvc;
using DataLayer;

namespace Project0.Controllers
{
    public class RestaurantController : Controller
    {
        readonly RestaurantCrud crud = new RestaurantCrud();

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurants/Create
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            try
            {
                crud.CreateRestaurant(restaurant);
                // log that it worked
                return RedirectToAction("Index");
            }
            catch
            {
                // log some problem
                return View("Index");
            }
        }

        // GET: Restaurant/Edit
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Restaurants/Edit
        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            try
            {
                crud.UpdateRestaurant(restaurant);
                // log that it worked
                return RedirectToAction("Show", restaurant.id);
            }
            catch
            {
                // log some problem
                return View("Show", restaurant.id);
            }
        }


        // GET: Restaurant
        public ActionResult Index()
        {
            return View(crud.GetRestaurants());
        }


        // GET: Restaurant/Show/id
        public ActionResult Show(int? id)
        {
            if (id==0||id==null)
            {
                return RedirectToAction("Index");
            }
            else

            return View(crud.GetRestaurant(Convert.ToInt32(id)));
        }

        // GET: Restaurant/Delete/id
        public ActionResult Delete(int id)
        {
            crud.DeleteRestaurant(id);
            return RedirectToAction("Index");
        }
    }
}