using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Longhorn_Music_Team_17.ViewModels
{
    public class SongReportViewModel
    {
        public string SongTitle { get; set; }
        public int SongID { get; set; }
        public int NumberOfPurchase { get; set; }
        public decimal Revenue { get; set; }
    }
}