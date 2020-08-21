using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutViewsExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        [Route("Home/Index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Home/About")]
        public ActionResult About()
        {
            return View();
        }

        [Route("Home/Contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("Home/UserProfile")]
        public ActionResult UserProfile()
        {
            return View();
        }
    }
}