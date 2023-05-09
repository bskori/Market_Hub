using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApp.CustAuthFilter;
using StoreApp.Models;
using StoreApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Areas.Store.Controllers
{
    [Area("Store")]
    [StoreAuth]
    public class StoreHomeController : Controller
    {
        StoreAppContext cntx;
        public StoreHomeController(StoreAppContext tcntx)
        {
            this.cntx = tcntx;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
                var urec = this.cntx.Stores.SingleOrDefault(p => p.StoreID == storeid);
                if (urec.Paassword == rec.OldPassword)
                {
                    urec.Paassword = rec.NewPassword;
                    this.cntx.SaveChanges();
                    ViewBag.Message = "Password Changed !";
                    return View();
                }
                else
                {
                    ModelState.AddModelError("", "Inalid OLD Password!");
                    return View(rec);
                }
            }
            return View(rec);
        }
    }
}
