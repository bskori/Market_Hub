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
    public class ManageUsersController:Controller
    {
        StoreAppContext cntx;
        public ManageUsersController(StoreAppContext tcntx)
        {
            this.cntx = tcntx;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserVM rec)
        {
            if (ModelState.IsValid)
            {
                User urec = new User();
                urec.Address = rec.Address;
                urec.EmailID = rec.EmailID;
                urec.MobileNo = rec.MobileNo;
                urec.FirstName = rec.FirstName;
                urec.LastName = rec.LastName;
                urec.Password = rec.Password;
                this.cntx.Users.Add(urec);
                this.cntx.SaveChanges();
                return RedirectToAction("SignIn");
            }
            return View(rec);
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
                var strec = this.cntx.Users.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
                if (strec != null)
                {
                    HttpContext.Session.SetString("UserID", strec.UserID.ToString());
                    HttpContext.Session.SetString("UserName", strec.FirstName);
                    return RedirectToAction("Index", "Home");
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
