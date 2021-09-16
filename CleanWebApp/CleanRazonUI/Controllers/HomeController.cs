using System.Collections.Generic;
using System.Diagnostics;
using CleanRazonUI.Infrastructure;
using CleanRazonUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CleanRazonUI.Controllers
{
    public class HomeController : Controller
    {
        //[TypeFilter(typeof(ExceptionLogingAttribute))]
        public IActionResult Index()
        {
            Product product = new Product()
            {
                Id = 1,
                Name = "Test"
            };
            if (true) throw new System.Exception();
            return View(product);
        }
        //[ExceptionLoging]
        public IActionResult Catalog()
        {
            //if (true) throw new System.Exception();
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

            string[] source = { "item 1", "item 2", "item 3" };
            SelectList selectList = new SelectList(source, source[1]);
            ViewBag.SelectItems = selectList;

            return View(contacts);
        }

        [HttpPost]
        public IActionResult Contacts(string selectedItem)
        {
            Debug.WriteLine(selectedItem);
            return View("Result", selectedItem);
        }
        //PROFILE FILTER SET INTO STARTUP.CS
        //[Profile]
        [ResultProfile]
        public IActionResult SendRequests()
        {
            return View(new FormViewModel() { Name = "default", TermsAccepted = true });
        }

        [HttpPost]
        public IActionResult SendRequests(FormViewModel model, List<string> addresses)
        {
            //if (string.IsNullOrWhiteSpace(model.Name))
            //{
            //    ModelState.AddModelError(nameof(model.Name), "name is empty");
            //}
            if (!ModelState.IsValid)
            {
                Debug.WriteLine("error");
                return View();
            }
            else
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
        }

        [HttpPost]
        public IActionResult Index([FromHeader] string myValue)
        {
            Debug.WriteLine("Transfered Value = " + myValue);
            return View();
        }
    }
}