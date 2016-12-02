using Longhorn_Music_Team_17.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System;

//Change the namespace here to match your project's name

namespace Longhorn_Music_Team_17.Controllers

{

    [Authorize]

    public class AccountController : Controller

    {

        public enum ManageMessageId

        {

            AddPhoneSuccess,

            ChangePasswordSuccess,

            SetTwoFactorSuccess,

            SetPasswordSuccess,

            RemoveLoginSuccess,

            RemovePhoneSuccess,

            DetailsChangeSuccess,

            CardDeleteSuccess,

            Error

        }




        private AppSignInManager _signInManager;

        private AppUserManager _userManager;

        AppDbContext db = new AppDbContext();




        public AccountController()

        {

        }




        public AccountController(AppUserManager userManager, AppSignInManager signInManager)

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


        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (HttpContext.User.Identity.IsAuthenticated)//NOTE: User has been re-directed here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            AuthenticationManager.SignOut();  //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                AppUser userLoggingIn = db.Users.FirstOrDefault(x => x.Email == model.Email);

                if (await UserManager.IsInRoleAsync(userLoggingIn.Id, "DisabledEmployee"))
                {
                    return View("Error", new string[] { "Your employee account has been disabled." });
                }
            }
            catch (NullReferenceException e)
            {
                new ApplicationException("Invalid Email", e);
            }

            var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);

            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }




        //

        // GET: /Account/Register

        [AllowAnonymous]

        public ActionResult Register()

        {

            return View();

        }




        //

        // POST: /Account/Register

        [HttpPost]

        [AllowAnonymous]

        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Register(RegisterViewModel model)

        {

            if (ModelState.IsValid)

            {

                //TODO: Add fields to user here so they will be saved to the database

                //Create a new user with all the properties you need for the class

                var user = new AppUser { UserName = model.Email, Email = model.Email, FirstName = model.FirstName, MiddleInitial = model.MiddleInitial, LastName = model.LastName, PhoneNumber = model.PhoneNumber, StreetAddress = model.StreetAddress, ZipCode = model.ZipCode, City = model.City, State = model.State };




                //Add the new user to the database

                var result = await UserManager.CreateAsync(user, model.Password);







                if (result.Succeeded) //user was created successfully

                {




                    if (User.IsInRole("Manager"))

                    {

                        await UserManager.AddToRoleAsync(user.Id, "Employee");
                        SendEmployeeEmail(user);
                    }

                    else

                    {

                        await UserManager.AddToRoleAsync(user.Id, "Customer");

                        SendRegisterEmail(user);

                             await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    }







                    //send them to the home page

                    return RedirectToAction("Index", "Home");

                }




                //if there was a problem, add the error messages to what we will display

                AddErrors(result);

            }




            // If we got this far, something failed, redisplay form

            return View(model);

        }






        // POST: /Account/LogOff

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult LogOff()

        {

            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

            return RedirectToAction("Index", "Home");

        }







        // GET: /Account/ChangePassword

        public ActionResult ChangePassword()

        {

            return View();

        }







        // POST: /Account/ChangePassword

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)

        {

            if (!ModelState.IsValid)

            {

                return View(model);

            }

            var result = await UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);

            if (result.Succeeded)

            {

                var user = await UserManager.FindByIdAsync(User.Identity.GetUserId());

                if (user != null)

                {

                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                }

                return RedirectToAction("Index", new { Message = ManageMessageId.ChangePasswordSuccess });

            }

            AddErrors(result);

            return View(model);

        }




        // GET: /Account/SetPassword

        public ActionResult SetPassword(string id)

        {

            var userId = id;

            if (string.IsNullOrEmpty(id))

            {

                userId = User.Identity.GetUserId();

            }

            var model = new SetPasswordViewModel

            {
                UserID = userId

            };




            return View(model);

        }


        // POST: /Account/SetPassword

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<ActionResult> SetPassword(SetPasswordViewModel model)

        {

            if (!ModelState.IsValid)

            {

                return View(model);

            }
            UserManager.RemovePassword(model.UserID);

            var result = await UserManager.AddPasswordAsync(model.UserID, model.NewPassword);

            if (result.Succeeded)

            {

                var user = await UserManager.FindByIdAsync(model.UserID);

                if (user != null)

                {

                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                }

                return RedirectToAction("Index", new { Message = ManageMessageId.SetPasswordSuccess });

            }

            AddErrors(result);

            return View(model);

        }




        // GET: /Account/Index

        public ActionResult Index(string id, ManageMessageId? message)

        {

            ViewBag.StatusMessage =

                message == ManageMessageId.ChangePasswordSuccess ? "Password has been changed successfully."

                : message == ManageMessageId.SetPasswordSuccess ? "Password has been set successfully."

                : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."

                : message == ManageMessageId.Error ? "An error has occurred."

                : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."

                : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."

                : message == ManageMessageId.DetailsChangeSuccess ? "Account Details have been changed successfully."

                 : message == ManageMessageId.CardDeleteSuccess ? "Card was deleted successfully."

                : "";




            var userId = id;

            if (string.IsNullOrEmpty(id))

            {

                userId = User.Identity.GetUserId();

            }

            var user = db.Users.SingleOrDefault(u => u.Id == userId);




            var model = new UserModel()

            {




                FirstName = user.FirstName,

                LastName = user.LastName,

                City = user.City,

                State = user.State,

                EmailAddress = user.Email,

                PhoneNumber = user.PhoneNumber,

                StreetAddress = user.StreetAddress,

                UserModelID = user.Id,

                ZipCode = user.ZipCode,

                HasPassword = (user.PasswordHash != null),

                Cards = user.Cards,

                Orders = user.Orders.OrderByDescending(x => x.OrderDate).ToList()


            };




            if (UserManager.IsInRole(user.Id, "Manager"))

            {

                model.Role = "Manager";

            }

            else if

            (UserManager.IsInRole(user.Id, "Employee"))

            {

                model.Role = "Employee";

            }

            else

            {

                model.Role = "Customer";

            }




            return View(model);




        }




        // get: edit account details




        public ActionResult Edit(string id)

        {

            var userId = id;

            if (string.IsNullOrEmpty(id))

            {

                userId = User.Identity.GetUserId();

            }

            var user = db.Users.SingleOrDefault(u => u.Id == userId);
        



            var model = new UserModel()

            {




                FirstName = user.FirstName,

                LastName = user.LastName,

                City = user.City,

                State = user.State,

                EmailAddress = user.Email,

                PhoneNumber = user.PhoneNumber,

                StreetAddress = user.StreetAddress,

                UserModelID = user.Id,

                ZipCode = user.ZipCode,

                HasPassword = (user.PasswordHash != null),

                Cards = user.Cards

            };




            if (UserManager.IsInRole(user.Id, "Manager"))

            {

                model.Role = "Manager";

            }

            else if

            (UserManager.IsInRole(user.Id, "Employee"))

            {

                model.Role = "Employee";

            }

            else

            {

                model.Role = "Customer";

            }




            return View(model);

        }




        // post: edit account details

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Edit([Bind(Include = "FirstName,LastName,EmailAddress,PhoneNumber,StreetAddress,ZipCode,City,State,UserModelID")] UserModel model)

        {




            if (ModelState.IsValid)

            {




                var user = UserManager.FindById(model.UserModelID);

                user.FirstName = model.FirstName;

                user.LastName = model.LastName;

                user.Email = model.EmailAddress;

                user.PhoneNumber = model.PhoneNumber;

                user.StreetAddress = model.StreetAddress;

                user.ZipCode = model.ZipCode;

                user.City = model.City;

                user.State = model.State;




                var result = await UserManager.UpdateAsync(user);

                if (!result.Succeeded)

                {

                    AddErrors(result);

                    return RedirectToAction("Edit", new { Id = model.UserModelID });




                }

                return RedirectToAction("Index", new { Id = model.UserModelID, message = ManageMessageId.DetailsChangeSuccess });

            }

            return View(model);

        }




        [Authorize(Roles = "Employee, Manager")]

        public ActionResult Customers()

        {

            var role = db.Roles.FirstOrDefault(x => x.Name == "Customer");

            var users = db.Users

            .Where(x => x.Roles.Any(y => y.RoleId.Equals(role.Id)))

            .ToList();




            return View(users);

        }




        [Authorize(Roles = "Manager")]

        public ActionResult Employees()

        {

            var role = db.Roles.FirstOrDefault(x => x.Name == "Employee");

            var users = db.Users

            .Where(x => x.Roles.Any(y => y.RoleId.Equals(role.Id)))

            .ToList();




            return View(users);

        }







        [Authorize]

        public ActionResult AddCard()

        {


            AppUser user = UserManager.FindById(User.Identity.GetUserId());
            var model = new Card() { AppUserId = user.Id, AppUser = user };

            return View(model);

        }




        [Authorize]

        [HttpPost]

        [ValidateAntiForgeryToken]




        public ActionResult AddCard([Bind(Include = "CardID,AppUserId,CardNumber,Type,ExpDate,CVV")]Card card)

        {
         
            if (ModelState.IsValid)
            {

                db.Cards.Add(card);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = card.AppUserId });
            }




            return View(card);

        }




        [Authorize]

        public ActionResult DeleteCard(int Id)

        {

            var card = db.Cards.SingleOrDefault(c => c.CardID == Id);




            if (card != null)

            {

                var userID = card.AppUserId;

                db.Cards.Remove(card);

                db.SaveChanges();

                return RedirectToAction("Index", new { id = userID, message = ManageMessageId.CardDeleteSuccess });

            }




            return RedirectToAction("Index", new { id = User.Identity.GetUserId() });




        }




        //method to edit card information

        public ActionResult CardEdit()

        {

            var user = UserManager.FindById(User.Identity.GetUserId());

            return View();

        }







        private bool HasPassword()

        {

            var user = UserManager.FindById(User.Identity.GetUserId());

            if (user != null)

            {

                return user.PasswordHash != null;

            }
            return false;
        }
        protected override void Dispose(bool disposing)

        {

            if (disposing)

            {

                if (_userManager != null)

                {

                    _userManager.Dispose();

                    _userManager = null;

                }

                if (_signInManager != null)

                {

                    _signInManager.Dispose();

                    _signInManager = null;

                }

            }

            base.Dispose(disposing);

        }

        private IAuthenticationManager AuthenticationManager

        {

            get

            {

                return HttpContext.GetOwinContext().Authentication;

            }

        }
        private void AddErrors(IdentityResult result)

        {

            foreach (var error in result.Errors)

            {

                ModelState.AddModelError("", error);           
            }
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))

            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        private bool AuthorizedToEdit(string id)
        {
            if (id != User.Identity.GetUserId())
            {
                if (UserManager.IsInRole(id, "Customer") && !(User.IsInRole("Employee") || User.IsInRole("Manager")))
                {
                    return false;
                }
                else if (UserManager.IsInRole(id, "Employee") && !User.IsInRole("Manager"))
                {
                    return false;
                }
            }
            return true;
        }

        private void SendRegisterEmail(AppUser user)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dear {user.FirstName},<br/><br/>");
            sb.AppendLine("Welcome to Longhorn Music!");
            EmailMessaging.SendEmail(user.Email, "Welcome to Longhorn Music", sb.ToString());

        }

        
        private void SendEmployeeEmail(AppUser user)
        {

            var body = $@"Dear {user.FirstName}, you have been registered as an employee";
            EmailMessaging.SendEmail(user.Email, "LHM Employee Registration Confirmation", body);
        }

    }

}









