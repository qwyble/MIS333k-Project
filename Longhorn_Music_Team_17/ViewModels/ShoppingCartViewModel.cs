using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Longhorn_Music_Team_17.Models;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }

        public string CartTotal { get; set; }

        public string Tax { get; set; }

        public string Total { get; set; }
    }
}