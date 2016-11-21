using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Artist
    {
        public Int32 ArtistID { get; set; }

        [Display(Name = "Artist Name")]
        public String ArtistName { get; set; }

        public Boolean FeaturedArtist { get; set; }


        //navigation properties
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Album> Albums { get; set; }
        public virtual List<Song> Songs { get; set; }
        public virtual List<Rating> Ratings { get; set; }
    }
}