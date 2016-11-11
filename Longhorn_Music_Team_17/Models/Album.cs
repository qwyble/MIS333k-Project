using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Album
    {
        public Int32 AlbumID { get; set; }  //auto generate album primary key

        [Display(Name = "Album")]
        public String AlbumTitle { get; set; }

        public Decimal AlbumPrice { get; set; }

        public bool FeaturedAlbum { get; set; }


        //navigation properties
        public virtual List<Song> Songs { get; set; }  //an album has >1 song
        public virtual List<Artist> Artists { get; set; } //an album has one artist(?)
        public virtual List<Genre> Genres { get; set; }  //an album can have many artists genre; do these properties need to have same/different names in different classes?
        public virtual OrderDetail OrderDetail { get; set; } //an album can have only one order detail; bridge table with payload

    }
}