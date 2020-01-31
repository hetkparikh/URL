using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger("Test");//ConfigurationManager.AppSettings["LoggerID"].ToString());

        protected void Application_Start()
        {
                        AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
