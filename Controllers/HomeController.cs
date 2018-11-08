using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffee_Shop.Models;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult AddUser(UserInfo newUser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.WelcomeMessage = $"Welcome {newUser.FirstName}!";
                return View("Confirmation");
            }
            else
            {
                return View("@Html.ValidationSummary()");
            }
        }
    }
}