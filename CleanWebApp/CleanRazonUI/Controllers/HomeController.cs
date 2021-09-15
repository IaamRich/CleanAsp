﻿using System;
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
    }
}
