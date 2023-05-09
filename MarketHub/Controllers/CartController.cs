using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreApp.CustAuthFilter;
using StoreApp.Models;
using StoreApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Controllers
{

    [UserAuth]
    public class CartController : Controller
    {
        StoreAppContext cntx;
        public CartController(StoreAppContext stcntx)
        {
            this.cntx = stcntx;
        }
        public IActionResult AddToCart(Int64 id)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            Product prod = this.cntx.Products.Find(id);
            var ucart = this.cntx.Carts.SingleOrDefault(p => p.UserID == userid && p.ProductID == id);
            if (ucart != null)
            {
                ucart.Qty++;
                this.cntx.SaveChanges();
            }
            else
            {
                Cart newcart = new Cart();
                newcart.Price = prod.Price;
                newcart.ProductID = id;
                newcart.Qty = 1;
                newcart.UserID = userid;
                this.cntx.Carts.Add(newcart);
                this.cntx.SaveChanges();
            }
            return RedirectToAction("GetProducts","Home",new {id=prod.CategoryID});
        }

        public IActionResult GetCart()
        {

            ViewBag.PaymentMode = new SelectList(new string[] {"Cash On Delivery","Card/NetBanking" });

            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var cart = this.cntx.Carts.Where(p => p.UserID == userid);
            return View(cart.ToList());
        }

        public IActionResult DeleteCart(Int64 id)
        {
            var carrec = this.cntx.Carts.Find(id);
            this.cntx.Carts.Remove(carrec);
            this.cntx.SaveChanges();
            return RedirectToAction("GetCart");
        }
        public IActionResult MakePayment(string PaymentMode)
        {
            if (PaymentMode == "Cash On Delivery")
            {
                return RedirectToAction("PlaceOrder", new { flag = false });
            }
            else
            {
                return RedirectToAction("PaymentGateway");
            }
        }

        [HttpGet]
        public IActionResult PaymentGateway()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PaymentGateWay(PaymentGatewayVM rec)
        {
            ///ok

            return RedirectToAction("PlaceOrder",new { flag=true});
        }
        public IActionResult PlaceOrder(bool flag)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var cart = this.cntx.Carts.Where(p => p.UserID == userid);

            //userorder 
            UserOrder uord = new UserOrder();
            uord.IsPaid = flag;
            uord.OrderDateTime = DateTime.Now;
            uord.UserID = userid;

            foreach (var temp in cart)
            {
                UserOrderDet uodet = new UserOrderDet();
                uodet.Price = temp.Price;
                uodet.ProductID = temp.ProductID;
                uodet.Qty = temp.Qty;
                uord.UserOrderDets.Add(uodet);
            }

            this.cntx.UserOrders.Add(uord);
            this.cntx.SaveChanges();

            //remove cart
            var newcart = this.cntx.Carts.Where(p => p.UserID == userid);
            foreach (var temp in newcart)
            {
                this.cntx.Carts.Remove(temp);
            }

            this.cntx.SaveChanges();

            ViewBag.Message = "Order palced Success Fully!";
            return View();
        }
    }
}
