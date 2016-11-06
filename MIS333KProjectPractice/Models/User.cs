using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace MIS333KProjectPractice.Models
{
    public class User
    {
        [Required]   //does CustomerID need to be required?
        [Display(Name = "User ID")]
        public Int32 UserID { get; set; } //account number in project data?

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [StringLength(1)]
        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid emial address.")] //why the two different error messages?
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email Address")]
        public String EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)] //this doesn't seem to ensure that a proper phone number is entered
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter street address.")]
        [Display(Name = "Street Address")]
        public String StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter zip code.")]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Please enter a valid zip code.")]   //is this the best way to validate zip code?   
        public Int32 ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [Display(Name = "Password")]
        public String Password { get; set; }
      
        public bool Enabled { get; set; }

        public String UserReview { get; set; }

        //navigation properties
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Card> Cards { get; set; }
    }
}