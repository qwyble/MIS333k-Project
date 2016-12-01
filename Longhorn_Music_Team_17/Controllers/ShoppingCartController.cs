using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.Models;
using Longhorn_Music_Team_17.ViewModels;

namespace Longhorn_Music_Team_17.Controllers
{
    public class ShoppingCartController : Controller
    {
        AppDbContext db = new AppDbContext();  //intantiate database in controller

        // GET: /ShoppingCart/
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal().ToString("C"),
                Tax = cart.GetTax().ToString("C"),
                Total = cart.GrandTotal().ToString("C")
            };
            // Return the view
            return View(viewModel);
        }
        //
        // GET: /Store/AddToCart/5
        public ActionResult AddAlbumToCart(int id)
        {
            // Retrieve the album from the database
            var addedAlbum = db.Albums
                .Single(album => album.AlbumID == id);

            // Add it to the shopping cart
            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddAlbumToCart(addedAlbum);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        public ActionResult AddSongToCart(int id)
        {
            // Retrieve the album from the database
            var addedSong = db.Songs
                .Single(song => song.SongID == id);

            // Add it to the shopping cart
            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddSongToCart(addedSong);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        //
        // AJAX: /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Remove the item from the cart
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Get the name of the album to display confirmation
            string title = string.Empty;

            if (db.Carts.Single(item => item.RecordID == id)?.AlbumID != null)
            {
                title = db.Carts.Single(item => item.RecordID == id).Album.AlbumTitle;
            }
            else
            {
                title = db.Carts.Single(item => item.RecordID == id).Song.SongTitle;
            }

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel
            {

                Message = Server.HtmlEncode(title) +

                    " has been removed from your shopping cart.",

                CartTotal = cart.GetTotal(),
                Tax = cart.GetTax(),
                Total = cart.GrandTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,

                DeleteId = id
            };
            return Json(results);
        }
        //
        // GET: /ShoppingCart/CartSummary
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
    }
}