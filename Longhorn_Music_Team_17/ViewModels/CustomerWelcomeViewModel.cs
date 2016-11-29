using Longhorn_Music_Team_17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class CustomerWelcomeViewModel
    {
        public string CustomerName { get; set; }

        public Song FeaturedSong { get; set; }

        public Artist FeaturedArtist { get; set; }

        public Album FeaturedAlbum { get; set; }

        
    }
}