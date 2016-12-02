using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class AlbumReportViewModel
    {
        public string AlbumTitle { get; set; }
        public int AlbumID { get; set; }
        public int NumberOfPurchase { get; set; }
        public decimal Revenue { get; set; }
    }
}
