using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayTemplates.Models;

namespace DisplayTemplates.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var roles = new List<Role>() {new Role() {ID = 1, Name = "Programmer"}, new Role() {ID = 2, Name = "Developer"}};
            var users = new List<User>() {new User() {FirstName = "Fido", MiddleInitial = "S", LastName = "Dido", DateOfBirth = DateTime.Now, IsAdmin = false, Roles = roles}};
            return View(users);

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