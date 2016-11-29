using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.Models;
using System.Data.Entity;
using Longhorn_Music_Team_17.ViewModels;
using Microsoft.AspNet.Identity;

namespace Longhorn_Music_Team_17.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db = new AppDbContext();

        // GET: Home
        public ActionResult Index()
        {
            var model = new CustomerWelcomeViewModel(); 
            if (User.IsInRole("Customer"))
            {
                var userId = User.Identity.GetUserId();
                var user = db.Users.SingleOrDefault(x => x.Id == userId);
                model.CustomerName = user.FirstName;
                model.FeaturedSong = new Song();
                model.FeaturedAlbum = new Album();
                model.FeaturedArtist = new Artist();
                
                var featuredSong = db.Songs.FirstOrDefault(x => x.FeaturedSong);
                var featuredAlbum = db.Albums.FirstOrDefault(x => x.FeaturedAlbum);
                var featuredArtist = db.Artists.FirstOrDefault(x => x.FeaturedArtist);
                if (featuredSong != null)
                {
                    model.FeaturedSong = featuredSong;
                }
                if (featuredAlbum != null)
                {
                    model.FeaturedAlbum = featuredAlbum;
                }
                if (featuredArtist != null)
                {
                    model.FeaturedArtist = featuredArtist;
                }
            }
            return View(model);
        }
    }
}