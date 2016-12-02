using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Longhorn_Music_Team_17.Controllers
{
    public class ReviewsController : Controller
    {
        private AppSignInManager _signInManager;
        private AppUserManager _userManager;
        AppDbContext db = new AppDbContext();
        public ReviewsController(){}
        public ReviewsController(AppUserManager userManager, AppSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        public AppSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<AppSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }
        public AppUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: Reviews
        public ActionResult Index()
        {
            var reviews = db.Reviews.Include(r => r.rating);
            return View(reviews.ToList());
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Reviews/Create
        public ActionResult Create(int? id, string name)
        {
            AppUser user = UserManager.FindById(User.Identity.GetUserId());
            if (name == "albumReview")
            {
                Album AlbumToRate = db.Albums.Find(id);
                if (AlbumToRate == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    var query = from o in user.Orders
                                from ord in db.OrderDetails
                                where ord.OrderID == o.OrderID
                                select ord;
                    var query2 = from od in query
                                 where AlbumToRate.AlbumID == od.AlbumID
                                 select od.Album;
                    System.Diagnostics.Debug.WriteLine(query.ToList());
                    var result = query2.ToList();
                    System.Diagnostics.Debug.WriteLine(result.Count());
                    if (result.Count == 0)
                    {
                        TempData["ReviewError"] = "You must purchase before reviewing.";

                        return RedirectToAction("Details", "Albums", new { id = id });
                    }
                }
            }
            if (name == "artistReview")
            {
                Artist ArtistToRate = db.Artists.Find(id);
                if (ArtistToRate == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    var query = from o in user.Orders
                                from ord in db.OrderDetails
                                where ord.OrderID == o.OrderID
                                select ord;
                    //check for artist against albums owned
                    var query2 = from od in query
                                 from al in db.Albums
                                 where al.AlbumID == od.AlbumID
                                 select al;
                    var query4 = from al in query2
                                 from art in al.Artists
                                 select art;
                    var artal = from art in query4
                                where art.ArtistID == ArtistToRate.ArtistID
                                select art;
                    //check for artist against songs owned
                    var query3 = from od in query
                                 from so in db.Songs
                                 where od.SongID == so.SongID
                                 select so;                    
                    var query5 = from s in query3
                                 from art in s.Artists
                                 select art;
                    var query6 = from art in query5 //songs
                                 where ArtistToRate.ArtistID == art.ArtistID
                                 select art;

                    System.Diagnostics.Debug.WriteLine(query.ToList());
                    var result1 = artal.ToList();
                    var result2 = query6.ToList();
                    if (result1.Count == 0 && result2.Count == 0)
                    {
                        TempData["ReviewError"] = "Purchase a song or album from this artist before reviewing.";

                        return RedirectToAction("Details", "Artists", new { id = id });
                    }
                }
            }

            if (name == "songReview")
            {
                Song SongToRate = db.Songs.Find(id);
                if (SongToRate == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    var query = from o in user.Orders
                                from ord in db.OrderDetails
                                where ord.OrderID == o.OrderID
                                select ord;
                    var query2 = from od in query
                                 where SongToRate.SongID == od.SongID
                                 select od.Song;
                    var result1 = query2.ToList();

                    var query3 = from o in user.Orders
                                from ord in db.OrderDetails
                                where ord.OrderID == o.OrderID
                                select ord;
                    var help = from al in SongToRate.Albums
                               select al;
                    var query4 = from od in query3
                                 from al in help
                                 where al.AlbumID == od.AlbumID
                                 select od.Album;
                    var result2 = query4.ToList();

                    if (result1.Count == 0 && result2.Count == 0)
                    {
                        TempData["ReviewError"] = "You must purchase before reviewing.";

                        return RedirectToAction("Details", "Songs", new { id = id });
                    }
                }
            }

            TempData["ID"] = id;
            TempData["reviewType"] = name;
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "RateNum,Comment")] Review review, int? id, string name)
        {
            if (id == null || name == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //set 'no choice' to null
            if (review.RateNum == 0)
            {
                review.RateNum = null;
            }
            //set rating
            review.rating = db.Ratings.Find((int)review.RateNum);

            if (name == "albumReview")
            {
                Album AlbumToRate = db.Albums.Find(id);
                //make sure item exists
                if (AlbumToRate == null)
                {
                    return HttpNotFound();
                }
                review.AlbumReview = AlbumToRate;
                if (ModelState.IsValid)
                {
                    review.Owner = db.Users.Find(User.Identity.GetUserId());
                    db.Reviews.Add(review);
                    db.SaveChanges();
                    return RedirectToAction("Details", "Albums", new { id = id });
                }
            }

            if (name == "songReview")
            {
                Song SongToRate = db.Songs.Find(id);
                //make sure item exists
                if (SongToRate == null)
                {
                    return HttpNotFound();
                }
                review.SongReview = SongToRate;
                if (ModelState.IsValid)
                {
                    review.Owner = db.Users.Find(User.Identity.GetUserId());
                    db.Reviews.Add(review);
                    db.SaveChanges();
                    return RedirectToAction("Details", "Songs", new { id = id });
                }
            }

            if (name == "artistReview")
            {
                Artist ArtistToRate = db.Artists.Find(id);
                //make sure item exists
                if (ArtistToRate == null)
                {
                    return HttpNotFound();
                }
                review.ArtistReview = ArtistToRate;
                if (ModelState.IsValid)
                {
                    review.Owner = db.Users.Find(User.Identity.GetUserId());
                    db.Reviews.Add(review);
                    db.SaveChanges();
                    return RedirectToAction("Details", "Artists", new { id = id });
                }
            }
            return View(review);
        }


        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            ViewBag.ReviewID = new SelectList(db.Ratings, "RatingID", "RatingID", review.ReviewID);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewID,Comment")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ReviewID = new SelectList(db.Ratings, "RatingID", "RatingID", review.ReviewID);
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
