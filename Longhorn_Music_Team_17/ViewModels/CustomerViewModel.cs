using Longhorn_Music_Team_17.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class CustomerViewModel
    {
        public UserModel CustomerDetails { get; set; }

        [UIHint("Card")]
        public IEnumerable<Card> Cards { get; set; }
        public List<Order> Orders { get; set; }

    }
}