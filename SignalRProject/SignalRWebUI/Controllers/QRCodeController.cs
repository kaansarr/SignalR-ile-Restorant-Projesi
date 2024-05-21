using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
