﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Longhorn_Music_Team_17.Models
{
    public class Card : IValidatableObject
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
        [Required(ErrorMessage = "Please specify your card type")]
        public CardType Type { get; set; }


        [Display(Name = "Card Number")]
        [Required(ErrorMessage = "Card Number is required")]
        [RegularExpression(@"^.{5,}$", ErrorMessage = "Invalid card number")]
        public string CardNumber
        {
            get { return (string.IsNullOrEmpty(_CardNumber)) ? string.Empty : string.Concat(string.Empty.PadLeft(_CardNumber.Length - 4, '*'), _CardNumber.Substring(_CardNumber.Length - 4)); }
            set { _CardNumber = value; }

        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!Regex.IsMatch(_CardNumber, @"^[0-9]{15,16}$"))
            {
                yield return new ValidationResult
                 ("Card number is invalid", new[] { "CardNumber" });
            }

            if (_CardNumber.Length == 15 && Type != CardType.AmericanExpress)
            {
                yield return new ValidationResult
                    ("Card number does not match card type.");
            }
            if (_CardNumber.Substring(0,2) != "54" && Type == CardType.Mastercard)
            {
                yield return new ValidationResult
                    ("Card number does not match card type.");
            }
            if (_CardNumber.Substring(0,1) != "4" && Type == CardType.Visa)
            {
                yield return new ValidationResult
                    ("Card number does not match card type.");
            }
            if (_CardNumber.Substring(0,1) != "6" && Type == CardType.Discover)
            {
                yield return new ValidationResult
                    ("Card number does not match card type.");
            }

        }

        [Required]       
        [Display(Name = "Expiration Date")]
        public string ExpDate { get; set; }
        
        [Required]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Enter a valid CVV (3 digit numeric data)")]
        public string CVV { get; set; }

        public virtual AppUser AppUser { get; set; } //each card can have one user

    }
}
