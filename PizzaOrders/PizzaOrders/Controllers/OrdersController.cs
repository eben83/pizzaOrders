using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaOrders.Data;
using PizzaOrders.Models;

namespace PizzaOrders.Controllers
{
    public class OrdersController : Controller
    {

        private readonly ApplicationDbContext _db;

        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        }
        // POST - CREATE
        public IActionResult Create()
        {
            return View();
        }
    }
}