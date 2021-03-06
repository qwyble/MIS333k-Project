﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Order
    {
        public int OrderID { get; set; }
       

        public Int32 CardID { get; set; }

        [Required]
        public String AppUserId { get; set; }


        [Display(Name = "Type of Card")]
        public Card.CardType Type { get; set; }


        [Display(Name = "Card Number")]
        public string CardNumber
        {
            get;
            set;
        }

        [Display(Name = "Expiration Date")]
        public string ExpDate { get; set; }

        [RegularExpression(@"^\d{3}$", ErrorMessage = "Enter a valid CVV (3 digit numeric data)")]
        public string CVV { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        [Display(Name = "Is this a gift?")]
        public bool IsGift { get; set; }

        [Display(Name = "Gift Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string GiftEmail { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }


        //navigation properties
        public List<OrderDetail> OrderDetails { get; set; }
    }
}