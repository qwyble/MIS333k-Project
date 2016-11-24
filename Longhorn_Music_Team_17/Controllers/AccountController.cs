//Change the using statement here to match your project's name
using Longhorn_Music_Team_17.ViewModels;
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

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
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

                await UserManager.AddToRoleAsync(user.Id, "Customer"); //adds user to role called "Customer"

                if (result.Succeeded) //user was created successfully
                {
                    //sign the user in
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    //send them to the home page
                    return RedirectToAction("Index", "Home");
                }

                //if there was a problem, add the error messages to what we will display
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //register employees
        [HttpPost]
        [Authorize(Roles = "Manager")]
        public async Task<ActionResult> RegisterEmployee(RegisterEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                //TODO: Add fields to user here so they will be saved to the database
                //Create a new user with all the properties you need for the class
                var user = new AppUser { UserName = model.Email, Email = model.Email, FirstName = model.FirstName, MiddleInitial = model.MiddleInitial, LastName = model.LastName, PhoneNumber = model.PhoneNumber, StreetAddress = model.StreetAddress, ZipCode = model.ZipCode };

                //Add the new user to the database
                var result = await UserManager.CreateAsync(user, model.Password);

                //TODO: Once you get roles working, you may want to add users to roles upon creation
                await UserManager.AddToRoleAsync(user.Id, "Employee"); //adds user to role called "Employee"

                if (result.Succeeded) //user was created successfully
                {

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
        [Authorize]
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
        [Authorize]
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

        // GET: /Account/Index
        [Authorize]
        public ActionResult Index(ManageMessageId? message)
        {
            var userId = User.Identity.GetUserId();
            var user = UserManager.FindById(userId);
            
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
                : message == ManageMessageId.Error ? "An error has occurred."
                : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
                : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
                : "";

            //create user viewmodel
            var model = new CustomerViewModel
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

        // get: edit account details
        [Authorize]
        public ActionResult Edit(int? id)
        {
            var userId = User.Identity.GetUserId();
            var user = UserManager.FindById(userId);

            //set up the view model
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
                ZipCode = user.ZipCode   
            };

            return View(model);
        }

        // post: edit account details
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> Edit([Bind(Include = "FirstName,LastName,EmailAddress,PhoneNumber,StreetAddress,City,State,ZipCode")] UserModel @UserModel)
        {
            if (ModelState.IsValid)
            {
                var user = UserManager.FindById(User.Identity.GetUserId());
                user.FirstName = @UserModel.FirstName;
                user.LastName = @UserModel.LastName;
                user.Email = @UserModel.EmailAddress;
                user.PhoneNumber = @UserModel.PhoneNumber;
                user.StreetAddress = @UserModel.StreetAddress;
                user.City = @UserModel.City;
                user.State = @UserModel.State;
                user.ZipCode = @UserModel.ZipCode;

                var result = await UserManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    AddErrors(result);
                    return View(@UserModel);

                }
                return RedirectToAction("Index");
            }
            return View(@UserModel);
        }

        [Authorize]
        public ActionResult AddCard()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user.Cards.Count() > 1)
            {
                ViewBag.CardsMaxed = true;
                ViewBag.ErrorMessage = "Only two credit cards are allowed per account.";
                return RedirectToAction("Index");
            }
            var model = new Card();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddCard([Bind(Include = "CardNumber,CVV,Type,ExpDate")] Card @card)
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user.Cards.Count() > 1)
            {
                ViewBag.CardsMaxed = true;
                ViewBag.ErrorMessage = "Only two credit cards are allowed per account.";
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                @card.AppUserId = user.Id;
                db.Cards.Add(@card);
                db.SaveChanges();
                return RedirectToAction("Index");
                
            }
            
            return View(@card);
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
    }
}