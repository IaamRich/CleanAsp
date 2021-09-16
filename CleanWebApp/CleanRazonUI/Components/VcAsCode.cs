using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace CleanRazonUI.Components
{
    public class VcAsCode : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            IHtmlContent content = new HtmlString("<p><p><p><b>Returned ViewComponent as html code, or Another code with markup CONTENTViewComponentresult </b></p></p></p>");
            HtmlContentViewComponentResult result = new HtmlContentViewComponentResult(content);
            return result;
        }
    }
}
