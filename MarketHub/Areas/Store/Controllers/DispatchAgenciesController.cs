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
    public class DispatchAgenciesController : Controller
    {
        StoreAppContext cntx;
        public DispatchAgenciesController(StoreAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.cntx.DispatchAgencies.ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(DispatchAgency rec)
        {
            if (ModelState.IsValid)
            {
                this.cntx.DispatchAgencies.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rec);
        }


        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            DispatchAgency mcrec = this.cntx.DispatchAgencies.Find(id);
            return View(mcrec);
        }


        [HttpPost]
        public ActionResult Edit(DispatchAgency rec)
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
            DispatchAgency mc = this.cntx.DispatchAgencies.Find(id);
            this.cntx.DispatchAgencies.Remove(mc);
            this.cntx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
