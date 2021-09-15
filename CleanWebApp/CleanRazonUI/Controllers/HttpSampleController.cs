using Microsoft.AspNetCore.Mvc;

namespace CleanRazonUI.Controllers
{
    //public class HttpSampleController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        var result = "Got result";
    //        return View(result as object);
    //    }
    //}
    public class HttpSampleController
    {
        public string Index() => "Got result";
    }
}