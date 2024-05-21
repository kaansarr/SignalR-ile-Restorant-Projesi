using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClienUserCount()   
        {
            return View();
        }
    }
}
