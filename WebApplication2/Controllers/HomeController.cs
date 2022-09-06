using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            Dbo_englishClubEntities db = new Dbo_englishClubEntities();
            List<tbl_main> mains = db.tbl_main.ToList();
            return View(mains);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Redirect()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}