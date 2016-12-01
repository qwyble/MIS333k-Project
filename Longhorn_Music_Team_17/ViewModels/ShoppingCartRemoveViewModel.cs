using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Longhorn_Music_Team_17.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }
}

