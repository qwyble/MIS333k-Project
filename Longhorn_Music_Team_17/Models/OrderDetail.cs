using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int? AlbumID { get; set; }
        public int? SongID { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal UnitPrice { get; set; }

        //navigation properties
        public virtual Album Album { get; set; } 
        public virtual Order Order { get; set; }  
        public virtual Song Song { get; set; }
    }
}