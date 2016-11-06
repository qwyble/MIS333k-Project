using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIS333KProjectPractice.DAL;
using MIS333KProjectPractice.Models;

using System.Data.Entity;


namespace MIS333KProjectPractice.Controllers
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