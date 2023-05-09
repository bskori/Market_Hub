using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Controllers
{
    public class HomeController : Controller
    {
        StoreAppContext cntx;
        public HomeController(StoreAppContext tcntx)
        {
            this.cntx = tcntx;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult GetProducts(Int64 id=0)
        {
            if (id == 0)
                return View(this.cntx.Products.ToList());
            else
            {
                var res = from t in this.cntx.Products
                          where t.CategoryID == id
                          select t;
                return View(res.ToList());
            }
        }
    }
}
