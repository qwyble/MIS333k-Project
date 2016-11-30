using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Review
    {
        //scalar properties
        public Int32 ReviewID { get; set; }

        //public Int32 Rating { get; set; }
        [Required(ErrorMessage = "If you don't have anything to say, you can just leave a rating.")]
        public String Comment { get; set; }

        //navigation properties
        [Required]
        public virtual Rating rating { get; set; }
        public virtual Song SongReview { get; set; }  //each review is for one song
        public virtual Album AlbumReview { get; set; }  //each review is for one album
        public virtual Artist ArtistReview { get; set; } //each review is for one artist 


    }
}