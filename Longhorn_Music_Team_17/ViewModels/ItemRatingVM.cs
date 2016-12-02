using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Longhorn_Music_Team_17.Models;
namespace Longhorn_Music_Team_17.ViewModels
{
    public class ItemRatingVM
    {
        public Song song { get; set; }
        public Artist artist { get; set; }
        public Album album { get; set; }
        public double rating { get; set; }
    }
}