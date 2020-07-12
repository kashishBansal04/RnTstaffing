using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebKashish.Models;

namespace WebKashish.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult whychooseus()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Permanentrecruitment()
        {
            return View();
        }

        public ActionResult Contractualstaffing()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {            
            
            return View();
        }
    }
}