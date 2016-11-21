using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Cart
    {
        [Key]
        public int RecordID { get; set; }
        public string CartID { get; set; }
        public int? AlbumID { get; set; }
        public int? SongID { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        //navigation properties
        public virtual Album Album { get; set; }
        public virtual Song Song { get; set; }


    }
}