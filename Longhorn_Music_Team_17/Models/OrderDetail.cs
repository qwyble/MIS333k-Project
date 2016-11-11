using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.Models
{
    public class OrderDetail
    {
        public Int32 OrderDetailID { get; set; }

        public Decimal PurchasePrice { get; set; }

        //navigational properties
        public virtual List<Album> Albums { get; set; }
        public virtual List<Song> Songs { get; set; }
        public virtual List<Order> Orders { get; set; } //each order detail can have many orders; bridge table with payload
    }
}