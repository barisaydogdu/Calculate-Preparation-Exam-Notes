using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DuiyesController : Controller
    {
        // GET: Duiyes
        public ActionResult Duiyes()
        {
            return View(new duiyesmodel());
        }
        [HttpPost]
        public ActionResult Duiyes(duiyesmodel duiyesmodel,string calculate)
        {
            double reading = duiyesmodel.reading * 1.25;
            double listening = duiyesmodel.listening * 1.25;
            double grammar = duiyesmodel.grammar * 1.25;
            double vocablary = duiyesmodel.vocablary * 1.25;
            int writing = duiyesmodel.writing;
            double firstpart = (reading + listening + grammar + vocablary) * 80 / 100;
            int secondpart = writing * 20 / 100;
            if(calculate=="miss")
            {
                duiyesmodel.total = firstpart + secondpart;
            }
          
            return View(duiyesmodel);
        }

    }
}