using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Song
    {
        public Int32 SongID { get; set; }

        [Display(Name = "Song Title")]
        public string SongTitle { get; set; }

        [Display(Name = "Song Price")]
        public Decimal SongPrice { get; set; }

        /*public Song()
        {
            Genres = new List<Genre>();
        }  */

        [Display(Name = "Featured Song")]
        public bool FeaturedSong { get; set; }

        //navigation properties

        [Display(Name = "Artist")]
        public virtual List<Artist> Artists { get; set; }

        [Display(Name = "Album")]
        public virtual List<Album> Albums { get; set; }

        [Display(Name = "Genre")]
        public virtual List<Genre> Genres { get; set; }

        [Display(Name = "Rating")]
        public virtual List<Review> Reviews { get; set; }

        public virtual OrderDetail OrderDetail { get; set; } //each song can have only one order detail; bridge table with payload

        public virtual List<Rating> Ratings { get; set; }
    }
}