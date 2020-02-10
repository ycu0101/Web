using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //新增其他套件的方式
            //ViewEngines.Engines.Insert(0, new RazorView());
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception last_error = Server.GetLastError();

            //string err_msg = "";
            //if (last_error != null)
            //{
            //    err_msg = last_error.Message;
            //}
            

            ////若網頁沒有撰寫任何的錯誤處理，或是沒有回收清除(Server.ClearError)，最後將顯示預設錯誤畫面；反之若有清除則不再往下一個除錯流程。
            //Server.ClearError();

            ////導回首頁
            //Response.Redirect("Home/Index");
        }
    }
}
