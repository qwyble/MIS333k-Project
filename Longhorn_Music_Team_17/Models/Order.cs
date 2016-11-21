using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        private String _CardNumber;

        public Int32 CardID { get; set; }

        public String AppUserId { get; set; }


        [Display(Name = "Type of Card")]
        public Card.CardType Type { get; set; }


        [Display(Name = "Card Number")]
        public string CardNumber
        {
            get { return (string.IsNullOrEmpty(_CardNumber)) ? string.Empty : string.Concat(string.Empty.PadLeft(_CardNumber.Length - 4, '*'), _CardNumber.Substring(_CardNumber.Length - 4)); }
            set { _CardNumber = value; }

        }

        public string ExpDate { get; set; }


        public Int32 CVV { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        public bool IsGift { get; set; }

        public string GiftEmail { get; set; }

        public DateTime OrderDate { get; set; }


        //navigation properties
        public List<OrderDetail> OrderDetails { get; set; }
    }
}