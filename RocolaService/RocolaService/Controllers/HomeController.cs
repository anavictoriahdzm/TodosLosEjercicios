using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RocolaService.ServiceReference1;

namespace RocolaService.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult SearchList(string keyword)
        {
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            cliente.GetListYoutube(keyword);
            return View("SearchList");
        }

        public class video
        {
            public int VideoId { get; set; }
            public string Title { get; set; }
            public List<string> ListVideos { get; set; } 
        }
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
    }
}