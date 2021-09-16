using System;
using Microsoft.AspNetCore.Mvc;

namespace CleanRazonUI.Components
{
    public class VcAsView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
