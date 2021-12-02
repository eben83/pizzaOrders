using Microsoft.AspNetCore.Mvc;

namespace PizzaOrders.Controllers
{
    public class Challenge : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}