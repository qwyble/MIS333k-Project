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
        [StringLength(100, ErrorMessage = "Reviews cannot exceed 100 characters.")]
        public String Comment { get; set; }

        public enum RateEnum
        {
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5
        }

        [Required(ErrorMessage = "Please rate before reviewing")]
        public RateEnum? RateNum { get; set; }

        //navigation properties
        public virtual Rating rating { get; set; }
        public virtual Song SongReview { get; set; }  //each review is for one song
        public virtual Album AlbumReview { get; set; }  //each review is for one album
        public virtual Artist ArtistReview { get; set; } //each review is for one artist
        public virtual AppUser Owner { get; set; }


    }
}