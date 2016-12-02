using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class BandReportViewModel
    {
        public string GenreTitle { get; set; }
        public string BandName { get; set; }
        public decimal SongRevenue { get; set; }
        public Int32 SongPurchases { get; set; }
        public decimal AlbumRevenue { get; set; }
        public Int32 AlbumPurchases { get; set; }

    }
}