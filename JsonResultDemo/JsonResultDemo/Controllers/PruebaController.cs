﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweetinvi;

namespace JsonResultDemo.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Consulta()
        {
            //TwitterKey
            Auth.SetUserCredentials("OmnRr6g9E4nIdy5vW6IE9gJmD", "iY9kah88jg5Hw53qsfQ5UGzpif0V0mOK30Ar5ie2pBfVpFyHan"
                                   , "796462679758163971-NubG7GJva0P1BttmpQoGkot71YTc6f9"
                                   , "aODZ3wD1xD6lxifeWZPO4TzjY7ybD5gYojdMiQXDhEZjt");
            var usertw = Tweetinvi.User.GetAuthenticatedUser();

            //Lista de tweets
            var tw = Timeline.GetUserTimeline(usertw, 5);

            ViewBag.listatw = tw;
            return Json(tw, JsonRequestBehavior.AllowGet);
        }
    }
}