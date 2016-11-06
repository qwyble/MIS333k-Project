using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS333KProjectPractice.Models
{
    public class Rating
    {
        public Int32 RatingID { get; set; }

        public Int32 RatingScore { get; set; }

        public virtual List<Song> Songs { get; set; }
    }
}