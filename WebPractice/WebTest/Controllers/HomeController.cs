using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.EnumCode;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //Session[SessionTestID.First.ToString()] = "The Test For Session string";
            Session.Add(SessionTestID.First.ToString(), "TestForSession");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}