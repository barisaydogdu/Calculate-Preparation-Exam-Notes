using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ArticleListController : Controller
    {
        Dbo_englishClubEntities englishClubEntities = new Dbo_englishClubEntities();
        // GET: ArticleList
        [Authorize]
        public ActionResult Index()
        {
            using (englishClubEntities)
            {
                return View(englishClubEntities.tbl_main.ToList());
            }
        }

        // GET: ArticleList/Details/5
        public ActionResult Details(int id)
        {
            using (englishClubEntities)
            {
                return View(englishClubEntities.tbl_main.Where(x=>x.id==id).FirstOrDefault());
            }
               
        }

        // GET: ArticleList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleList/Create
        [HttpPost]
        public ActionResult Create(tbl_main tbl_Main)
        {
            try
            {
                // TODO: Add insert logic here
                using (englishClubEntities)
                {
                    englishClubEntities.tbl_main.Add(tbl_Main);
                    englishClubEntities.SaveChanges();  
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleList/Edit/5
        public ActionResult Edit(int id)
        {
            using (englishClubEntities)
            {
                return View(englishClubEntities.tbl_main.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: ArticleList/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tbl_main tbl_Main)
        {
            try
            {
                using (englishClubEntities)
                {
                    englishClubEntities.Entry(tbl_Main).State = EntityState.Modified;
                    englishClubEntities.SaveChanges();
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleList/Delete/5
        public ActionResult Delete(int id)
        {
            //yapı edit ile aynı 
            using (englishClubEntities)
            {
                return View(englishClubEntities.tbl_main.Where(x => x.id == id).FirstOrDefault());
            }

          
        }

        // POST: ArticleList/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (englishClubEntities)
                {
                    tbl_main tbl_Mainq = englishClubEntities.tbl_main.Where(x => x.id == id).FirstOrDefault();
                    englishClubEntities.tbl_main.Remove(tbl_Mainq);
                    englishClubEntities.SaveChanges();
                }
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
