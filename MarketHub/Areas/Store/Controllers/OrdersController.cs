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
    public class OrdersController : Controller
    {
        StoreAppContext cntx;
        public OrdersController(StoreAppContext ctemp)
        {
            this.cntx = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.cntx.UserOrders.ToList());
        }


        [HttpGet]
        public IActionResult DispatchOrder(Int64 id)
        {
            var uord = this.cntx.UserOrders.Find(id);
            return View(uord);
        }

        [HttpGet]
        public IActionResult ExecuteDispatchOrder(Int64 id)
        {
            ViewBag.DispatchAgencyID = new SelectList(this.cntx.DispatchAgencies.ToList(), "DispatchAgencyID", "DispatchAgencyName");
            ViewBag.OrderID = id;
            var uord = this.cntx.UserOrders.Find(id);
            ViewBag.Name = uord.User.FirstName;
            return View();
        }

        [HttpPost]
        public IActionResult ExecuteDispatchOrder(UserOrderdDispatch rec)
        {
            ViewBag.DispatchAgencyID = new SelectList(this.cntx.DispatchAgencies.ToList(), "DispatchAgencyID", "DispatchAgencyName");
            if (ModelState.IsValid)
            {
                rec.DispatchDate = DateTime.Now;
                this.cntx.UserOrderdDispatches.Add(rec);
                this.cntx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}
