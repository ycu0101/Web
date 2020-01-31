using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.EnumCode;
using WebTest.ViewModels;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //Session[SessionTestID.First.ToString()] = "The Test For Session string";
            Session.Add(SessionTestID.First.ToString(), "TestForSession");

            TestViewModel test_model = new TestViewModel();
            test_model.test_list = new List<TestViewModel>();

            for (int i = 0; i < 10; i++)
            {
                TestViewModel tmp = new TestViewModel();
                tmp.A = "Hello ";
                tmp.B = "Mother ";
                tmp.C = "Fucker ";

                test_model.test_list.Add(tmp);


            }

            string test = DateTime.Parse("").ToString("yyyy-MM-dd HH:mm:ss");


            return View(test_model);
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