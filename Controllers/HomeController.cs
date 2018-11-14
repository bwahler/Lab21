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
            CoffeeShopDBEntities index = new CoffeeShopDBEntities();
            ViewBag.index = index.Items.ToList<Item>();
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
        public ActionResult AddUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                CoffeeShopDBEntities database = new CoffeeShopDBEntities();
                database.Users.Add(newUser);
                database.SaveChanges();
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