using Microsoft.AspNetCore.Mvc;
using StoreApp.CustAuthFilter;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Areas.Store.Controllers
{
    [Area("Store")]
    [StoreAuth]
    public class MainCategoriesController : Controller
    {
        StoreAppContext cntx;
        public MainCategoriesController(StoreAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.cntx.MainCategories.ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(MainCategory rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.MainCategories.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index"); 
            }

            return View(rec);
        }


        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            MainCategory mcrec = this.cntx.MainCategories.Find(id);
            return View(mcrec);
        }


        [HttpPost]
        public ActionResult Edit(MainCategory rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            MainCategory mc = this.cntx.MainCategories.Find(id);
            this.cntx.MainCategories.Remove(mc);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
