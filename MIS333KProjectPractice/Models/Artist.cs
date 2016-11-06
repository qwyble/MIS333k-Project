using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS333KProjectPractice.Models
{
    public class Artist
    {
        public Int32 ArtistID { get; set; }

        public string ArtistName { get; set; }

        public bool FeaturedArtist { get; set; }


        //navigation properties
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Album> Albums { get; set; }
        public virtual List<Song> Songs { get; set; }
        

    }
}