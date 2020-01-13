using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(FormCollection get)
        {
            if (get.Count > 0)
            {
                ViewBag.Message = get["hi"].ToString();
            }
            else
            {
                ViewBag.Title = "Welcome !";
                ViewBag.Message = "Nothing";
                ViewBag.Url1 = "Google";
                ViewBag.Url2 = "Facebook";
                ViewBag.Url3 = "Instagram";
            }


            return View();
        }



        public ActionResult About(FormCollection get)
        {


            if (get .Count >0)
            {
                return RedirectToAction("Contact", "Home");
            }
            else
            {
                ViewBag.Message = get["hi"].ToString();
                return View();
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";



             
            return View();
        }


        public ActionResult ClickAction()
        {
            //Service1.WebServiceFET_APISoapClient fet_api = new Service1.WebServiceFET_APISoapClient();
            //FET_API.WebServiceFET_API fet_api = new FET_API.WebServiceFET_API();



            string str = Guid.NewGuid().ToString("N");
            ViewBag.Message = str;

            return View("Index");
        }
    }
}