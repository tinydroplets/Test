using System.Collections.Generic;
using System.Web.Mvc;
using SimpleMVC.Models;
using SimpleMVC.ViewModels;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var customer1 = new Customer() {Id = 1, Name = "Fido"};
            var customer2 = new Customer() {Id = 2, Name = "Dido"};

            var viewModel = new CustomerViewModel {Customers = new List<Customer>() {customer1, customer2}};
            return View(viewModel);
        }

        public ActionResult Edit(int id, string name)
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