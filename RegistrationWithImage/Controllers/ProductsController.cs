using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationWithImage.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult AddNewProduct()
        {
            return View();
        }
    }
}