using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class UserModel
    {

        [Display(Name = "User ID")]
        public String UserModelID { get; set; } //account number in project data?

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email address.")] //why the two different error messages?
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

        [Required(ErrorMessage = "Please enter city.")]
        public String City { get; set; }

        [Required(ErrorMessage = "Please enter state.")]       
        public String State { get; set; }

        [Required(ErrorMessage = "Please enter zip code.")]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Please enter a valid zip code.")]   //is this the best way to validate zip code?   
        public String ZipCode { get; set; }


        public string Role { get; set; }

        public bool HasPassword { get; set; }

        [UIHint("Card")]
        public IEnumerable<Card> Cards { get; set; }
        public List<Order> Orders { get; set; }


    }
}