using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Longhorn_Music_Team_17.Models
{
    public class Album
    {
        public Int32 AlbumID { get; set; }  //auto generate album primary key

        [Display(Name = "Album")]
        public String AlbumTitle { get; set; }

        [Display(Name = "Album Price")]
       // [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public Decimal AlbumPrice { get; set; }

        [Display(Name = "Discount Amount")]
        //[DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public Decimal DiscountAmount { get; set; }

        [Display(Name = "Discounted Price")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public Decimal DiscountedPrice { get { return AlbumPrice - DiscountAmount; } private set { } }

        [Display(Name = "Featured Album")]
        public bool FeaturedAlbum { get; set; }

        //navigation properties
        public virtual List<Song> Songs { get; set; }  //an album has >1 song
        public virtual List<Artist> Artists { get; set; } //an album can have many artists
        public virtual List<Genre> Genres { get; set; }  //an album can have many artists genre; do these properties need to have same/different names in different classes?
        public virtual List<Rating> Ratings { get; set; } //an album can have many ratings
    }
}