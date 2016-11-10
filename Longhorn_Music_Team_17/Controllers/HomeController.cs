using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Longhorn_Music_Team_17.DAL;
using Longhorn_Music_Team_17.Models;
using System.Data.Entity;

namespace Longhorn_Music_Team_17.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db = new AppDbContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}