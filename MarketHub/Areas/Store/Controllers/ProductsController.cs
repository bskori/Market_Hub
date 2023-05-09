using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreApp.CustAuthFilter;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Areas.Store.Controllers
{
    [Area("Store")]
    [StoreAuth]
    public class ProductsController : Controller
    {
        StoreAppContext cntx;
        IWebHostEnvironment iwebhost;
        public ProductsController(StoreAppContext ctemp,IWebHostEnvironment ihost)
        {
            this.cntx = ctemp;
            this.iwebhost = ihost;
        }
        public IActionResult Index()
        {
            return View(this.cntx.Products.ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(this.cntx.Categories.ToList(), "CategoryID", "CategoryName");
            return View();
        }


        [HttpPost]
        public ActionResult Create(Product rec)
        {
            ViewBag.Categories = new SelectList(this.cntx.Categories.ToList(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                if (rec.Photo.Length > 0)
                {
                    string lpath = @"\ProductPhotos\" + rec.Photo.FileName;
                    string apath = this.iwebhost.WebRootPath + lpath;
                    rec.Photo.CopyTo(new FileStream(apath, FileMode.Create));
                    rec.PhotoPath = lpath;
                }
                this.cntx.Products.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }


        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            Product mcrec = this.cntx.Products.Find(id);
            ViewBag.Categories = new SelectList(this.cntx.Categories.ToList(), "CategoryID", "CategoryName",mcrec.CategoryID);

            return View(mcrec);
        }


        [HttpPost]
        public ActionResult Edit(Product rec)
        {
            ViewBag.Categories = new SelectList(this.cntx.Categories.ToList(), "CategoryID", "CatgoryName",rec.CategoryID);

            if (ModelState.IsValid)
            {
                if (rec.Photo.Length > 0)
                {
                    string lpath = @"\ProductPhotos\" + rec.Photo.FileName;
                    string apath = this.iwebhost.WebRootPath + lpath;
                    rec.Photo.CopyTo(new FileStream(apath, FileMode.Create));
                    rec.PhotoPath = lpath;
                }

                this.cntx.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rec);
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            Product mc = this.cntx.Products.Find(id);
            this.cntx.Products.Remove(mc);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
