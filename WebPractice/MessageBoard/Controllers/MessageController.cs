using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageBoard.Controllers
{
    public class MessageController : Controller
    {

        public ActionResult MessageHome()
        {
            return View();
        }
    }
}