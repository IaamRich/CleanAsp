using System;
using Microsoft.AspNetCore.Mvc;

namespace CleanRazonUI.Components
{
    public class VCFromBase : ViewComponent
    {

        // point of entry to the ViewComponent
        public IViewComponentResult Invoke()
        {
            //закодированная строка как символы 
            return Content("<b>Returned ViewComponent as Symbols CONTENTViewComponentresult </b>");
        }
    }
}
