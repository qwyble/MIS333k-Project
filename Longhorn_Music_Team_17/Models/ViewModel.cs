using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.Models
{
    public class ViewModel
    {
        public Int32 ViewModelID { get; set; }

        public Song song { get; set; }

        public Artist artist { get; set; }

        public Album album { get; set; }

        public Genre genre { get; set; }
    }
}