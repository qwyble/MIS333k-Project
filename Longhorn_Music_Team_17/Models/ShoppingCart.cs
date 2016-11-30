using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Longhorn_Music_Team_17.Models

{
    public partial class ShoppingCart
    {
        AppDbContext db = new AppDbContext();  //instantiate the database

        string ShoppingCartID { get; set; }
        public const string CartSessionKey = "CartID";
        public static ShoppingCart GetCart(HttpContextBase context)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartID = cart.GetCartId(context);
            return cart;
        }

        // Helper method to simplify shopping cart calls
        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public void AddAlbumToCart(Album album)
        {
            // Get the matching cart and album instances
            var cartItem = db.Carts.SingleOrDefault(
                c => c.CartID == ShoppingCartID
                && c.AlbumID == album.AlbumID);

            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists
                cartItem = new Cart
                {
                    AlbumID = album.AlbumID,
                    CartID = ShoppingCartID,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                db.Carts.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,
                // then add one to the quantity
                cartItem.Count++;
            }
            // Save changes
            db.SaveChanges();
        }

        public void AddSongToCart(Song song)
        {
            // Get the matching cart and album instances
            var cartItem = db.Carts.SingleOrDefault(
                c => c.CartID == ShoppingCartID
                && c.SongID == song.SongID);

            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists
                cartItem = new Cart
                {
                    SongID = song.SongID,
                    CartID = ShoppingCartID,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                db.Carts.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,
                // then add one to the quantity
                cartItem.Count++;
            }
            // Save changes
            db.SaveChanges();
        }
        public int RemoveFromCart(int id)
        {
            // Get the cart
            var cartItem = db.Carts.Single(
                cart => cart.CartID == ShoppingCartID
                && cart.RecordID == id);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    db.Carts.Remove(cartItem);
                }
                // Save changes
                db.SaveChanges();
            }
            return itemCount;
        }

        public void EmptyCart()
        {
            var cartItems = db.Carts.Where(
                cart => cart.CartID == ShoppingCartID);

            foreach (var cartItem in cartItems)
            {
                db.Carts.Remove(cartItem);
            }
            // Save changes
            db.SaveChanges();
        }

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(cart => cart.CartID == ShoppingCartID).ToList();
        }

        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in db.Carts
                          where cartItems.CartID == ShoppingCartID
                          select (int?)cartItems.Count).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }

        public decimal GetTotal()
        {
            // Multiply album price by count of that album to get
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total

            /*   decimal? total = (from cartItems in db.Carts
                                 where cartItems.CartID == ShoppingCartID
                                 select (int?)cartItems.Count * ((cartItems.AlbumID != null) ? cartItems.Album.DiscountedPrice : cartItems.Song.DiscountedPrice)).Sum();
               return total ?? decimal.Zero;  */
            var cartItemsList = (from cartItems in db.Carts
                                 where cartItems.CartID == ShoppingCartID
                                 select cartItems).ToList();
            decimal total = 0;

            foreach (var item in cartItemsList)
            {
                total += item.Count * ((item.AlbumID != null) ? item.Album.DiscountedPrice : item.Song.DiscountedPrice);
            }
            return total;
        }

        public decimal GetTax()
        {
            decimal total = GetTotal();
            return (total * 0.0825m);
        }

        public decimal GrandTotal()
        {
            return GetTax() + GetTotal();
        }

        public Order CreateOrder(Order order)
        {
            decimal orderTotal = 0;

            var cartItems = GetCartItems();

            // Iterate over the items in the cart,
            // adding the order details for each

            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    AlbumID = item.AlbumID,
                    SongID = item.SongID,
                    OrderID = order.OrderID,
                    UnitPrice = ((item.AlbumID != null) ? item.Album.DiscountedPrice : item.Song.DiscountedPrice),
                    Quantity = item.Count
                };


                // Set the order total of the shopping cart
                orderTotal += (item.Count * ((item.AlbumID != null) ? item.Album.DiscountedPrice : item.Song.DiscountedPrice));

                db.OrderDetails.Add(orderDetail);
            }

            // Set the order's total to the orderTotal count
            order.Subtotal = orderTotal;
            order.Tax = GetTax();
            order.Total = GrandTotal();

            // Save the order


            // Empty the shopping cart

            EmptyCart();

            // Return the OrderId as the confirmation number
            return order;
        }

        // We're using HttpContextBase to allow access to cookies.
        public string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] =
                        context.User.Identity.Name;
                }
                else
                {

                    // Generate a new random GUID using System.Guid class
                    Guid tempCartID = Guid.NewGuid();

                    // Send tempCartId back to client as a cookie

                    context.Session[CartSessionKey] = tempCartID.ToString();

                }

            }

            return context.Session[CartSessionKey].ToString();

        }




        // When a user has logged in, migrate their shopping cart to

        // be associated with their username

        public void MigrateCart(string userName)

        {

            var shoppingCart = db.Carts.Where(

                c => c.CartID == ShoppingCartID);




            foreach (Cart item in shoppingCart)

            {

                item.CartID = userName;

            }

            db.SaveChanges();

        }

    }

}