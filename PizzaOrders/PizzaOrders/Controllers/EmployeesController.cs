using Microsoft.AspNetCore.Mvc;

namespace PizzaOrders.Controllers
{
    public class EmployeesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}