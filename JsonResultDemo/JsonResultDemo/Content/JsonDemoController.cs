using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Script.Serialization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JsonResultDemo.Models;
using Tweetinvi;

namespace JsonResultDemo.Content
{
    public class JsonDemoController : Controller
    {
        #region ActionControllers

        //<summary>
        //Welcome Note Message
        //<summary>
        //<returns>In a Json Format</returns>

        public JsonResult WelcomeNote()
        {
            bool isAdmin = false;
            //TODO: Check the user if it is admin or normal user, (true-Admin, false- Normal user)
            string output = isAdmin ? "Welcome to the Admin User" : "Welcome to the User";

            return Json(output, JsonRequestBehavior.AllowGet);
        }

        

        private List<UserModel> GetUsers()
        {
            var usersList = new List<UserModel>
            {
                new UserModel
                {
                    UserId = 1,
                    UserName = "Ram",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 1,
                    UserName = "chand",
                    Company = "Mindfire Solutions"
                },
                new UserModel
                {
                    UserId = 1,
                    UserName = "abc",
                    Company = "abc Solutions"
                }
            };

            return usersList;
        }

        public JsonResult GetUsersData()
        {
            var users = GetUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Sample()
        {
            return View();
        }

        [HttpPost]
        public JsonResult UpdateUsersDetail (string usersJson)
        {
            var js = new JavaScriptSerializer();
            UserModel[] user = js.Deserialize<UserModel[]>(usersJson);

            //TODO: user now contains the details, you can do required operations
            return Json("User Details are updated");
        }

        private List<UserModel> GetUsersHugeData()
        {
            var usersList = new List<UserModel>();
            UserModel user;
            for (int i = 1; i < 51000; i++)
            {
                user = new UserModel
                {
                    UserId = i,
                    UserName = "User-"+i,
                    Company = "Company-"+i
                };
                usersList.Add(user);
            }
            return usersList;
        }

        public JsonResult GetUsersHugeList()
        {
            var users = GetUsersHugeData();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        protected override JsonResult Json(object data, string contentType,
            Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonResult()
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior,
                MaxJsonLength = Int32.MaxValue
            };
        }

        #endregion



    }
}