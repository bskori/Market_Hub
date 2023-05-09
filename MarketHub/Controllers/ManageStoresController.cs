using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;
using StoreApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Controllers
{
    public class ManageStoresController : Controller
    {
        StoreAppContext cntx;
        public ManageStoresController(StoreAppContext tcntx)
        {
            this.cntx = tcntx;
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var strec = this.cntx.Stores.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Paassword == rec.Password);
                if (strec != null)
                {
                    HttpContext.Session.SetString("StoreID", strec.StoreID.ToString());
                    HttpContext.Session.SetString("StoreName", strec.StoreName);
                    return RedirectToAction("Index", "StoreHome", new { Area = "Store" });
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Email ID or Password!");
                    return View(rec);
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }

      
    }
}
