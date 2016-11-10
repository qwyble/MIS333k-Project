using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Card
    {
        public Int32 CardID { get; set; }

        public enum Cards   //list of cards
        {
            Visa,
            Mastercard,
            [Display(Name = "American Express")]
            AmericanExpress,
            Discover
        }

        [Display(Name = "Type of Card")]
        public Cards Cards1 { get; set; }

        [CreditCard]
        [Display(Name = "Credit Card #1")]
        public Int32 Card1 { get; set; } //second credit card?

        public DateTime ExpDate { get; set; }

        public Int32 CVV { get; set; }


        //navigational properties
        public virtual List<User> Users { get; set; }
    }
}