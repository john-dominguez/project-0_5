using System.Linq;
using System.Web.Mvc;
using DataLayer;

namespace Project0.Controllers
{
    public class ReviewController : Controller
    {
        RestaurantCrud crud = new RestaurantCrud();

        // GET: Review/Create
        public ActionResult Create(int id)
        {
            ViewBag.restaurant_id = id;
            return View();
        }

        // POST: Review/Create
        [HttpPost]
        public ActionResult Create(Review review)
        {
            try
            {
              //   review.restaurant_id = ViewBag.restaurant_id;
                crud.CreatetReview(review);
                // log that it worked
                return RedirectToAction("Show", "Restaurant", review.restaurant_id);
            }
            catch
            {
                // log some problem
                return RedirectToAction("Show", "Restaurant", review.restaurant_id);
            }
        }

        // GET: Review/Edit
        public ActionResult Edit(int id)
        {
            return View(crud.GetReview(id));
        }

        // POST: Review/Edit
        [HttpPost]
        public ActionResult Edit(Review review)
        {
            try
            {
                crud.UpdateReview(review);
                // log that it worked
                return RedirectToAction("Show", "Restaurant", new { id = review.restaurant_id });
            }
            catch
            {
                // log some problem
                return RedirectToAction("Show", "Restaurant", new {id = review.restaurant_id });
            }
        }

        // GET: Review/Delete/id
        public ActionResult Delete(int id)
        {
            int restaurantId = crud.GetReview(id).restaurant_id;
            crud.DeleteReview(id);
            return RedirectToAction("Show", "Restaurant", new {id = restaurantId});
        }
    }
}