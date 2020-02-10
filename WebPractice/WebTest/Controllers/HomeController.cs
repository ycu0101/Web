using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.EnumCode;
using WebTest.ViewModels;

namespace WebTest.Controllers
{
    public class test
    {
        public string t1 { get; set; }
        public string t2 { get; set; }
    }

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Session["TEST"] = "SESSION TEST";


            return View();
        }

        [HttpPost]
        public string Subscribe(FormCollection get)
        {
            if (get.HasKeys())
            {
                ViewBag.Title = "Ajax Post Test";
            }
            else
            {
                ViewBag.Title = "Ajax Get Test";
            }

            return "/Home/Contact";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult About()
        {
            if (Session["TEST"] == null)
            {
                Session["TEST"] = "NO SESSION";
            }

            return View();
        }
    }
}