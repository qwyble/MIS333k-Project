using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.Models
{
    public class Genre
    {
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre Name")]
        [Required(ErrorMessage = "Genre name is required")]
        public string GenreName { get; set; }

        //navigational properties
        public virtual List<Artist> Artists { get; set; }
        public virtual List<Album> Albums { get; set; }
        public virtual List<Song> Songs { get; set; }
    }
}