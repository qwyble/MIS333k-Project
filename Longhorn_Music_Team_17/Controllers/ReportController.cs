using Longhorn_Music_Team_17.Models;
using Longhorn_Music_Team_17.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Longhorn_Music_Team_17.Controllers
{
    public class ReportController : Controller
    {
        AppDbContext db = new AppDbContext();
        // GET: Report

            public ActionResult Index()
        {
            return View();
        }

        public ActionResult SongReport()
        {
            var model = db.OrderDetails.Where(y => y.SongID != null && y.SongID != 0).GroupBy(o => new { SongID = o.Song.SongID, SongTitle = o.Song.SongTitle }).Select(g => new SongReportViewModel { SongID = g.Key.SongID, SongTitle = g.Key.SongTitle, Revenue = g.Sum(x => x.Subtotal), NumberOfPurchase = g.Sum(x => x.Quantity) });
            return View(model);
        }

        public ActionResult AlbumReport()
        {
            var model = db.OrderDetails.Where(y => y.AlbumID != null && y.AlbumID != 0).GroupBy(o => new { AlbumID = o.Album.AlbumID, AlbumTitle = o.Album.AlbumTitle }).Select(g => new AlbumReportViewModel { AlbumID = g.Key.AlbumID, AlbumTitle = g.Key.AlbumTitle, Revenue = g.Sum(x => x.Subtotal), NumberOfPurchase = g.Sum(x => x.Quantity) });
            return View(model);
        }
    }

}