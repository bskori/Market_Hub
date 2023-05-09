using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.ViewComponents
{
    public class Menu:ViewComponent
    {
        StoreAppContext cntx;
        public Menu(StoreAppContext tcntx)
        {
            this.cntx = tcntx;
        }

        public IViewComponentResult Invoke()
        {
            return View(this.cntx.MainCategories.ToList());
        }
    }
}
