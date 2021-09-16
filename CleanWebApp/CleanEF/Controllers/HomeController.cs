using System.Linq;
using CleanEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanEF.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext Context { get; }

        public HomeController(AppDbContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            return View(Context.Products.ToList());
        }
    }
}
