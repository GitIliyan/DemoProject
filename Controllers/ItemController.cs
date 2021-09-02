using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ItemController : Controller
    {
        //database entity 

        public ItemController()
        {

        }
        // GET: Item
        public ActionResult Index()
        {
            IDs objIDs = new IDs();
            
            
            return View();
        }
        [HttpPost]
        public JsonResult Index(IDs objIDs)
        {
            return Json(data:"HHH", JsonRequestBehavior.AllowGet);

        }
    }
}