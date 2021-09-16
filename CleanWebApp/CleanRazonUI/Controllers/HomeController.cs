using System.Collections.Generic;
using System.Diagnostics;
using CleanRazonUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanRazonUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Test"
            };
            return View(product);
        }

        public IActionResult Catalog()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Test"
            };
            return View(product);
        }

        public IActionResult Contacts()
        {
            ContactsViewModel contacts = new ContactsViewModel()
            {
                Email = "gggwe@gewg.com",
                Phone = "+ 3553 2235 23",
                Address = "2345 Jozeph street 57GH"
            };
            return View(contacts);
        }

        public IActionResult SendRequests()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendRequests(FormViewModel model, List<string> addresses)
        {
            Debug.WriteLine(model.Name);
            Debug.WriteLine(model.Address);
            Debug.WriteLine(model.Phone);
            foreach (var item in addresses)
            {
                Debug.WriteLine(item);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromHeader] string myValue)
        {
            Debug.WriteLine("Transfered Value = " + myValue);
            return View();
        }
    }
}