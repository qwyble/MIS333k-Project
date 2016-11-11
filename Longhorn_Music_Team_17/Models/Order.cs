using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Order
    {
        public Int32 OrderID { get; set; }

        public Decimal PurchasePrice { get; set; } //is this correct?

        public DateTime OrderDate { get; set; }

        public Decimal Discount { get; set; }

        public OrderStatus Status { get; set; }

        public enum OrderStatus
        {
            Cart,
            Checkout,
            Completed
        }

        //navigational properties
        public virtual AppUser AppUsers { get; set; }
        public virtual List<Song> Songs { get; set; }
        public virtual List<Album> Albums { get; set; }
        public virtual OrderDetail OrderDetail { get; set; } //each order can have only one order detail
    }
}