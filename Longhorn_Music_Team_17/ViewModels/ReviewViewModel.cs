using Longhorn_Music_Team_17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class ReviewViewModel
    {
        public List<Cart> CartItems { get; set; }

        public string CartTotal { get; set; }

        public string Tax { get; set; }

        public string Total { get; set; }

        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Display(Name = "Gift Email")]
        public string GiftEmail { get; set; }

        [Display(Name = "Is this a gift?")]
        public bool IsGift { get; set; }
    }
}