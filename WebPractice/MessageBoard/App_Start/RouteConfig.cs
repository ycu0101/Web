using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MessageBoard
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            /*
             * 使用 routes 時，他的吃法是由上到下
             * 並且不同種類的擴充功能只要有一個符合就不會繼續往下帶
             * 例如：執行完 IgnoreRoute 後，執行 MapRoute，但是第一個 name 為 "Test"，以符合 Route 的結果
             * 所以並不會接著執行到 name 為 "Default" 的 Route
             * 也因此會發生一種情況，今天並沒有 Home/Account/Resister 的網址，卻因為符合了 "Test" Route 的結果
             * 故不會帶到 "Default" 去，為解決這個問題，需使用到 Constraints 或是 Namespaces
             */

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //會產生問題的 MapRoute 寫法
            //routes.MapRoute(
            //    name: "Test",
            //    url: "{action}/{id}",
            //    defaults: new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    }
            //);

            routes.MapRoute(
                name: "Test",
                url: "{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "About",
                    id = UrlParameter.Optional
                },
                constraints: new { action = "About" }, //限制只有 About 會被比對到，其餘會到其他的 Route 去，在沒有就到 Default 去
                // constraints: new { action = "(About|Contact)" }  => 可利用 Regex 語法(正規表示式)同時允許 About 以及 Contact
                namespaces: new[] {"MessageBoard.Controllers"} //限制只有命名空間一樣才會比對成功
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
