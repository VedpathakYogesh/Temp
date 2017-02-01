using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using log4net.Config;

namespace Log4Net_dash.Controllers
{
    public class HomeController : Controller

    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static HomeController()
        {
            XmlConfigurator.Configure();
        }

        public ActionResult Index()
        {
            log.DebugFormat("log item [{0}]", 1);
            log.DebugFormat("log item [{0}]", 2);
            log.DebugFormat("log item [{0}]", 3);
            log.DebugFormat("log item [{0}]", 4);
            log.DebugFormat("log item [{0}]", 5);

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