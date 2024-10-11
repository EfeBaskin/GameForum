using GameForumWeb.Data;
using GameForumWeb.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GameForumWeb.Controllers
{
    public class GameController : Controller
    {
        private readonly GameContext db = new GameContext();

        public ActionResult Index(string platform = "All")
        {
            IQueryable<Game> games = db.Games;   //we take all data from Games table

            if (!string.IsNullOrEmpty(platform) && platform != "All")  // we apply (where) if it is not null and is not All
            {
                games = games.Where(g => g.Platform == platform);
            }

            return View(games.ToList());
        }



        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User model)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult AddGame()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGame(Game game)
        {
            if (ModelState.IsValid)
            {
                db.Games.Add(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(game);
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int id)
        {
            var game = db.Games.SingleOrDefault(g => g.Id == id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var game = db.Games.SingleOrDefault(g => g.Id == id);
            if (game != null)
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult ReviewIndex()
        {
            var reviews = db.Reviews.Include("User").Include("Game").ToList();
            return View(reviews);
        }

        public ActionResult GetUpdatedReview(int id)
        {
            var review = db.Reviews.Find(id);

            
            ViewBag.Games = new SelectList(db.Games, "Id", "GameName", review.GameId);

            return View(review);
        }


        [HttpPost]
        public ActionResult UpdateReview(Review review, int userId)
        {
            var existingReview = db.Reviews.Find(review.Id);
            if (existingReview != null)
            {
                existingReview.GameId = review.GameId;
                existingReview.ReviewContent = review.ReviewContent;
                existingReview.UserId = userId; 

                db.SaveChanges();
            }

            return RedirectToAction("ReviewIndex");
        }

        public ActionResult DeleteReview(int id)
        {
            var review = db.Reviews.Find(id);
            if (review != null)
            {
                db.Reviews.Remove(review);
                db.SaveChanges();
            }
            return RedirectToAction("ReviewIndex");
        }

        public ActionResult AddReview()
        {
            ViewBag.Users = new SelectList(db.Users, "Id", "Username");
            ViewBag.Games = new SelectList(db.Games, "Id", "GameName");

            return View();
        }

        [HttpPost]
        public ActionResult AddReview(Review review, int userId)
        {
            if (ModelState.IsValid)
            {
                review.UserId = userId; 
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("ReviewIndex");
            }

            ViewBag.Users = new SelectList(db.Users, "Id", "Username");
            ViewBag.Games = new SelectList(db.Games, "Id", "GameName");

            return View(review);
        }


        public ActionResult Bookmark()
        {
            // Fetch all bookmarks, including related User and Game entities
            var bookmarks = db.Bookmarks
                              .Include("User")  
                              .Include("Game")  
                              .ToList();     

            return View(bookmarks);  
        }
    }

    #region not necessary
    //public ActionResult AddReview()
    //{
    //    var model = new ReviewViewModel
    //    {
    //        Users = db.Users.Select(u => new SelectListItem
    //        {
    //            Value = u.Id.ToString(),
    //            Text = u.Username,
    //        }),
    //        Games = db.Games.Select(g => new SelectListItem
    //        {
    //            Value = g.Id.ToString(),
    //            Text = g.GameName
    //        })
    //    };

    //    return View(model);
    //}

    //[HttpPost]
    //public ActionResult AddReview(ReviewViewModel model)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        var review = new Review
    //        {
    //            UserId = model.UserId,
    //            GameId = model.GameId,
    //            ReviewContent = model.ReviewContent
    //        };

    //        db.Reviews.Add(review);
    //        db.SaveChanges();

    //        return RedirectToAction("Index");
    //    }

    //    model.Users = db.Users.Select(u => new SelectListItem
    //    {
    //        Value = u.Id.ToString(),
    //        Text = u.Username,
    //    });
    //    model.Games = db.Games.Select(g => new SelectListItem
    //    {
    //        Value = g.Id.ToString(),
    //        Text = g.GameName
    //    });

    //    return View(model);
    //}
    //public ActionResult EditReview(int id)
    //{
    //    var review = db.Reviews.Find(id);
    //    return View(review);
    //}

    //[HttpPost]
    //public ActionResult GoEditReview(Review model)
    //{
    //    var review = db.Reviews.Find(model.UserId);
    //    review.ReviewContent = model.ReviewContent;
    //    db.SaveChanges();

    //    return RedirectToAction("Index");
    //}
    #endregion
}
