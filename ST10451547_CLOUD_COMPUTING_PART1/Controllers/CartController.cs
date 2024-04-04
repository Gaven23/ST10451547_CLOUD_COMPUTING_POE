using Microsoft.AspNetCore.Mvc;

namespace ST10451547_CLOUD_COMPUTING_PART1.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CartController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
