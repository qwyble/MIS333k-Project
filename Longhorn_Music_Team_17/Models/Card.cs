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
        public Cards CardType { get; set; }


        [Display(Name = "Credit Card Number")]
        public string CardNum { get; set; }


        public Int32 CVV { get; set; }


        //navigational properties
        public virtual List<AppUser> AppUsers { get; set; }
    }
}