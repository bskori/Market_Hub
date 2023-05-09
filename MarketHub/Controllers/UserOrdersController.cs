using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApp.CustAuthFilter;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Controllers
{
    [UserAuth]
    public class UserOrdersController : Controller
    {
        StoreAppContext cntx;
        public UserOrdersController(StoreAppContext stcntx) 
        {
            this.cntx = stcntx;
        }
        public IActionResult Index()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var uord = this.cntx.UserOrders.Where(p => p.UserID == userid);
            return View(uord.ToList());
        }
        public IActionResult ViewDispatchDetails(Int64 id)
        {
            var disprec = this.cntx.UserOrderdDispatches.Where(p => p.UserOrderID == id);
            if (disprec.Any())
            {
                ViewBag.Message("Order Disapthed!");
                return View(disprec.ToList());
            }
            else
            {
                ViewBag.Message("Order Not Dispatched!");
                return View();
            }
        }
    }
}
