using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwitterMvcApp.Controllers
{
    public class TwitterController : Controller
    {
        private string Key = System.Configuration.ConfigurationManager.AppSettings["Key"];
        private string Secret = System.Configuration.ConfigurationManager.AppSettings["Secret"];

        public ActionResult Auth(string oauth_token, string oauth_verifier)
        {
            var t = new TwitterApi.Twitter();
            //the 4th parameter is blank since we dont have it
            //and accounting to twitter docs its not needed https://dev.twitter.com/oauth/references/post/oauth/access_token

            return RedirectToAction("Welcome", "Home", new { screenName = result });
        }

    }
}