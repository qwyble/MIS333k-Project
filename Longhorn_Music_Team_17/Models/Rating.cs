using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Longhorn_Music_Team_17.Models
{
    public class Rating
    {
        public Int32 RatingID { get; set; }
        [Required(ErrorMessage = "Please enter a rating")]
        public Int32 RatingScore { get; set; }

        public virtual List<Song> Songs { get; set; }
        public virtual List<Album> Albums { get; set; }
        public virtual List<Artist> Artists { get; set; }
        public virtual List<Review> review { get; set; }
    }
}