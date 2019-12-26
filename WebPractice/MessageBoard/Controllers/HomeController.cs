﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {



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


        public ActionResult ClickAction()
        {
            //Service1.WebServiceFET_APISoapClient fet_api = new Service1.WebServiceFET_APISoapClient();
            FET_API.WebServiceFET_API fet_api = new FET_API.WebServiceFET_API();

            //string str = "Hello World";

            //ViewBag.Message = fet_api.HelloWorld();

            return View("Index");
        }
    }
}