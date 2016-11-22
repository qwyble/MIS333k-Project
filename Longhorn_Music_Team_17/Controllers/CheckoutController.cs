using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.Models;
using Longhorn_Music_Team_17.ViewModels;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using Microsoft.AspNet.Identity.Owin;

namespace Longhorn_Music_Team_17.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        AppDbContext db = new AppDbContext();

        private AppSignInManager _signInManager;
        private AppUserManager _userManager;
        

        public CheckoutController()
        {
        }

        public CheckoutController(AppUserManager userManager, AppSignInManager signInManager)
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

        // GET: Checkout
        public ActionResult NewOrder()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            // Set up our ViewModel
            var model = new CheckoutViewModel
            {
                Subtotal = cart.GetTotal().ToString("C"),
                Tax = cart.GetTax().ToString("C"),
                Total = cart.GrandTotal().ToString("C")
            };

            model.ListOfCards = new List<SelectListItem>();
            var userId = User.Identity.GetUserId();
            var user = db.Users.Include(x => x.Cards).Single(x => x.Id == userId);
            if (user != null)
            {
                foreach (var card in user.Cards)
                {
                    model.ListOfCards.Add(new SelectListItem { Text = $"{card.CardNumber} {card.Type.ToString()}", Value = $"{card.CardNumber} {card.Type.ToString()}" });
                }
            }
            model.IsGift = false;
            return View(model);
        }

        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewOrder(CheckoutViewModel model)
        {
            if (ModelState.IsValid)
            {

                TempData["checkout"] = model;

                return RedirectToAction("Review");
            }
            return View(model);


        }

        public ActionResult Review()
        {
            var model = TempData["checkout"] as CheckoutViewModel;
            var cart = ShoppingCart.GetCart(this.HttpContext);
            // Set up our ViewModel
            var viewModel = new ReviewViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal().ToString("C"),
                Tax = cart.GetTax().ToString("C"),
                Total = cart.GrandTotal().ToString("C")
            };
            if (model.CardOption == "NewCard")
            {
                viewModel.CardNumber = model.CardNumber;
            }
            else
            {
                viewModel.CardNumber = model.SelectedCardNumber;
            }
            viewModel.GiftEmail = model.GiftEmail;
            viewModel.IsGift = model.IsGift;
            // Return the view
            return View(viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Review(ReviewViewModel model)
        {
            var order = new Order();


            try
            {


                //order.Username = User.Identity.Name;
                order.OrderDate = DateTime.Now;

                //Save Order
                db.Orders.Add(order);
                db.SaveChanges();
                order.AppUserId = User.Identity.GetUserId();
                //Process the order
                var cart = ShoppingCart.GetCart(this.HttpContext);

                order = cart.CreateOrder(order);
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
               if (string.IsNullOrEmpty(model.GiftEmail))
                {
                    SendEmailToUser();
                }
                else
                {
                    SendEmailToGiftReciever(model.GiftEmail);
                    SendEmailToGiftPurchaser();
                }

                return RedirectToAction("Complete",
                    new { id = order.OrderID });

            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }

            return View(model);
        }

        private void SendEmailToGiftPurchaser()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            var body = $@"Dear {user.FirstName}, Thanks for ordering! Your gift has been sent.";
            EmailMessaging.SendEmail(user.Email, "Order Confirmation", body);
        }

        private void SendEmailToGiftReciever(string giftEmail)
        {
            var user = UserManager.FindByEmail(giftEmail);
            var body = $@"Dear {user.FirstName}, You have recieved a gift.";
            EmailMessaging.SendEmail(user.Email, "You have recieved a gift.", body);
        }

        private void SendEmailToUser()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());          
            var body = $@"Dear {user.FirstName}, Thanks for ordering!";
            EmailMessaging.SendEmail(user.Email, "Order Confirmation", body);



        }

        // GET: /Checkout/Complete

        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            var userId = User.Identity.GetUserId();
            bool isValid = db.Orders.Any(
                o => o.OrderID == id &&
                o.AppUserId == userId);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }


}