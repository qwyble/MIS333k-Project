using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Card
    {
        private String _CardNumber;

        public Int32 CardID { get; set; }

        public String AppUserId { get; set; }   //get rid of this later

        public enum CardType  //list of cards
        {
            Visa,
            Mastercard,
            [Display(Name = "American Express")]
            AmericanExpress,
            Discover
        }

        [Display(Name = "Type of Card")]
        public CardType Type { get; set; }


        [Display(Name = "Card Number")]
        public string CardNumber
        {
            get { return (string.IsNullOrEmpty(_CardNumber)) ? string.Empty : string.Concat(string.Empty.PadLeft(_CardNumber.Length - 4, '*'), _CardNumber.Substring(_CardNumber.Length - 4)); }
            set { _CardNumber = value; }

        }

        public string ExpDate { get; set; }
        

        public virtual AppUser Owner { get; set; }

        public Int32 CVV { get; set; }
    }
}
