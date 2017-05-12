using Ninject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebCommerce
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IKernel kernel = new StandardKernel();
            //WebApiConfig.Register(GlobalConfiguration.Configuration);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpCookie langCookie = HttpContext.Current.Request.Cookies["Language"];
            if(langCookie!= null && langCookie.Value!= null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(langCookie.Value);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(langCookie.Value);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("vi");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi");
            }
        }

    }
}
