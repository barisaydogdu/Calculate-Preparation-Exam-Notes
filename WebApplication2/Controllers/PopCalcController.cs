using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PopCalcController : Controller
    {
        // GET: PopCalc
        public ActionResult FourTeenWeekers()
        {
            return View(new popCalc());
            
        }
        [HttpPost]
        public ActionResult FourTeenWeekers(popCalc popcalc,string calculate)
        {
            double quiz = (popcalc.quiz) * 5 / 100;
            double wt1 = (popcalc.wt1) * 2.5 / 100;
            double mid = (popcalc.mid) * 15 / 100;
            double wt2 = (popcalc.wt2) * 2.5 / 100;
            double spe = (popcalc.spe) * 5 / 100;
            double op = (popcalc.op) * 5 / 100;
            double cp = (popcalc.cp) * 5 / 100;
            double pop = (popcalc.pop) * 60 / 100;


            if (calculate=="miss")
            {
                popcalc.tot = quiz +wt1 + mid + wt2 + spe + op + cp + pop;

            }
            return View(popcalc);
        }

        //Seven Weekers


        public ActionResult SevenWeekers()
        {
            return View(new popCalcSeven());

        }
        [HttpPost]
        public ActionResult SevenWeekers(popCalcSeven popcalc, string calculate)
        {
            double wt1 = (popcalc.wt1) * 2.5 / 100;
            double mid = (popcalc.mid) * 20 / 100;
            double wt2 = (popcalc.wt2) * 2.5 / 100;
            double spe= (popcalc.spe) * 5 / 100;
            double op = (popcalc.op) * 5 / 100;
            double cp = (popcalc.cp) * 5/ 100;
            double pop = (popcalc.pop) * 60 / 100;


            if (calculate == "miss")
            {
                popcalc.tot = wt1 + mid + wt2 + spe + op + cp + pop;

            }
            return View(popcalc);
        }

    }
}