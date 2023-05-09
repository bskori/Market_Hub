using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.ViewComponents
{
    public class CategoryList:ViewComponent
    {
        StoreAppContext cntx;
        public CategoryList(StoreAppContext sa)
        {
            this.cntx = sa;
        }

        public IViewComponentResult Invoke()
        {
            return View(this.cntx.Categories.ToList());
        }
    }
}
