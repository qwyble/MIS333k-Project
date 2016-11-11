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

        public String Comment { get; set; }

        public enum RatingList
        {
            [Display(Name = "1")]
            OneStar = 1,
            [Display(Name = "2")]
            TwoStars = 2,
            [Display(Name = "3")]
            ThreeStars = 3,
            [Display(Name = "4")]
            FourStars = 4,
            [Display(Name = "5")]
            FiveStars = 5
        }  //enum for rating list? Why can't I just use numbers?

        public RatingList RatingLists { get; set; }


        //navigation properties
        public virtual Song SongReview { get; set; }  //each review is for one song
        public virtual Album AlbumReview { get; set; }  //each review is for one album
        public virtual Artist ArtistReview { get; set; } //each review is for one artist 
        //public virtual AppUser UserReview { get; set; }  //each review can have only one customer


    }
}