using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationWithImage.Models;

namespace RegistrationWithImage.Controllers
{
    public class ProductsController : Controller
    {
        RegisterImagesEntities db = new RegisterImagesEntities();
        // GET: Products
        public ActionResult AddNewProduct()
        {
            return View();
        }

        public ActionResult SaveData(tblProduct item)
        {
            //Write code for receive data from view and
            //save all data and image in database
            if (item.ProductName != null &&  item.Price != null && item.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(item.ImageUpload.FileName);
                string extension = Path.GetExtension(item.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
                item.PicUrl = fileName;
                item.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/AppFile/Images"),fileName));
                db.tblProducts.Add(item);
                db.SaveChanges();
            }

            var result = "Successfully added";
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}