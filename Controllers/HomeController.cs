using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffee_Shop.Models;
using System.Data.Entity;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CoffeeShopDBEntities index = new CoffeeShopDBEntities();
            ViewBag.items = index.Items.ToList();
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
                CoffeeShopDBEntities AddUser = new CoffeeShopDBEntities();
                AddUser.Users.Add(newUser);
                AddUser.SaveChanges();
                ViewBag.WelcomeMessage = $"Welcome {newUser.FirstName}!";
                return View("Confirmation");
            }
            else
            {
                return View("Error");
            }
        }
        public ActionResult AddItem()
        {
            return View();
        }
        public ActionResult SaveNewItem(Item newItem)
        {
            CoffeeShopDBEntities AddItem = new CoffeeShopDBEntities();
            AddItem.Items.Add(newItem);
            AddItem.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SaveItem(Item UpdateItem)
        {
            CoffeeShopDBEntities save = new CoffeeShopDBEntities();
            save.Entry(UpdateItem).State = EntityState.Modified;

            save.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteItem(string name )
        {
            CoffeeShopDBEntities delete = new CoffeeShopDBEntities();
            delete.Items.Remove(delete.Items.Find(name));
            delete.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ItemInfo(string name)
        {
            CoffeeShopDBEntities database = new CoffeeShopDBEntities();
            Item ItemToChange = database.Items.Find(name);
            ViewBag.ItemToChange = ItemToChange;
            return View(ItemToChange);
        }
    }
}