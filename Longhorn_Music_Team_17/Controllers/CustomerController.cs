using Microsoft.AspNet.Identity.Owin;
using Longhorn_Music_Team_17.Models;
using Longhorn_Music_Team_17.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Longhorn_Music_Team_17.Controllers
{
    public class CustomerController : Controller
    {
        private AppDbContext db = new AppDbContext();

        private AppUserManager _userManager;

        public CustomerController()
        {
        }

        public CustomerController(AppUserManager userManager)
        {
            UserManager = userManager;

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

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(string ID)
        {
            var user = db.Users.Single(u => u.Id == ID);
            if (user == null)
            {
            }
            var model = new CustomerViewModel()
            {
                CustomerDetails = new UserModel()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    City = user.City,
                    State = user.State,
                    EmailAddress = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    StreetAddress = user.StreetAddress,
                    UserModelID = user.Id,
                    ZipCode = user.ZipCode

                },
                Cards = user.Cards
            };
            return View(model);
        }
        public ActionResult AddCard(string Id)
        {
            /*  var items = from Card.CardType enumValue in Enum.GetValues(typeof(Card.CardType))
                          select new SelectListItem
                          {
                              Text = enumValue.ToString(),
                              Value = ((int)enumValue).ToString()
                          };
              ViewBag.CardTypes = items;  */
            var model = new Card() { AppUserId = Id };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AddCard([Bind(Include = "CardID,AppUserId,CardNumber,Type,ExpDate,CVV")]Card card)
        {

            if (ModelState.IsValid)
            {
                db.Cards.Add(card);
                db.SaveChanges();
                return RedirectToAction("Details", new { ID = card.AppUserId });
            }

            return View(card);
        }
    }
}