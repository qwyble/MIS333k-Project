using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Longhorn_Music_Team_17.Models
{
    public class Song
    {
        public Int32 SongID { get; set; }

        [Display(Name = "Song Title")]
        public string SongTitle { get; set; }

        [Display(Name = "Song Price")]
        public Decimal SongPrice { get; set; }

        [Display(Name = "Discount Amount")]
       // [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public Decimal DiscountAmount { get; set; }

        [Display(Name = "Discounted Price")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public Decimal DiscountedPrice { get { return SongPrice - DiscountAmount; } private set { } }

        [Display(Name = "Featured Song")]
        public bool FeaturedSong { get; set; }

        //navigation properties

        [Display(Name = "Artist(s)")]
        public virtual List<Artist> Artists { get; set; }

        [Display(Name = "Album(s)")]
        public virtual List<Album> Albums { get; set; }

        [Display(Name = "Genre(s)")]
        public virtual List<Genre> Genres { get; set; }

        
        public virtual List<Review> Reviews { get; set; }

        [Display(Name = "Rating")]
        public virtual List<Rating> Ratings { get; set; }
    }
}