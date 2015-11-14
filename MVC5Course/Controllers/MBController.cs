using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : BaseController
    {
        public ActionResult Index()
        {
            var data = new NewProductVM()
            {
                Price = 100,
                ProductName = "T-Shirt"
            };


            ViewData["MyName"] = "Will";

            ViewData["MyTitle"] = "ASP.NET MVC 1";
            ViewBag.MyTitle     = "ASP.NET MVC 2";

            ViewBag.Products = db.Product.Take(5).ToList();

            TempData["Msg"] = "test";

            ViewData.Model = data;

            return View();
        }
    }
}