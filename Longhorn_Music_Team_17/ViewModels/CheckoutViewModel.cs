﻿using Longhorn_Music_Team_17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class CheckoutViewModel
    {
        private String _CardNumber;

        public String SelectedCardNumber { get; set; }

        public String CardOption { get; set; }

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

        public string Subtotal { get; set; }

        public string Tax { get; set; }

        public string Total { get; set; }

        public bool IsGift { get; set; }

        public string GiftEmail { get; set; }

        public List<SelectListItem> ListOfCards { get; set; }




    }
}