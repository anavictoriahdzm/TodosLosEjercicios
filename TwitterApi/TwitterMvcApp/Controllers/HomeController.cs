using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwitterMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public string Key = System.Configuration.ConfigurationManager.AppSettings["Key"];
        public string Secret = System.Configuration.ConfigurationManager.AppSettings["Secret"];

        public ActionResult Index()
        {
            var t = new TwitterApi.Twitter();
            var url = t.GetRequestToken(Key, Secret, "http://735cec48.ngrok.io/Twitter/Autg");

            return Redirect(url);
        }

        public ActionResult Welcome(string screenName)
        {
            ViewBag.ScreenName = screenName;
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