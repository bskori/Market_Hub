using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class CategoriesController : Controller
    {
        StoreAppContext cntx;
        public CategoriesController(StoreAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.cntx.Categories.ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {
          ViewBag.MainCategorie = new SelectList(this.cntx.MainCategories.ToList(),"MainCategoryID","MainCategoryName");
            return View();
        }


        [HttpPost]
        public ActionResult Create(Category rec)
        {
            ViewBag.MainCategorie = new SelectList(this.cntx.MainCategories.ToList(), "MainCategoryID", "MainCategoryName");

            if (ModelState.IsValid)
            {
                this.cntx.Categories.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rec);
        }


        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
           
            Category mcrec = this.cntx.Categories.Find(id);
            ViewBag.MainCategorie = new SelectList(this.cntx.MainCategories.ToList(), "MainCategoryID", "MainCategoryName",mcrec.MainCategoryID);

            return View(mcrec);
        }


        [HttpPost]
        public ActionResult Edit(Category rec)
        {
            ViewBag.MainCategorie = new SelectList(this.cntx.MainCategories.ToList(), "MainCategoryID", "MainCategoryName");

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

            Category mc = this.cntx.Categories.Find(id);
            this.cntx.Categories.Remove(mc);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

