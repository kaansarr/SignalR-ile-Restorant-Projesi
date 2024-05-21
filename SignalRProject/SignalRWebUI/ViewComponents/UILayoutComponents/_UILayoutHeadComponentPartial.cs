using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace SignalRWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeadComponentPartial:ViewComponent 
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
