using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaOrders.Data;
using PizzaOrders.Models;

namespace PizzaOrders.Controllers
{
    public class OrderController : Controller
    {

        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        
        // Get - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order obj)
        {
            var employee = new Employee();
            var order = new Order();
            order.Employee = employee;
            order.EmployeeId = employee.EmployeeId;
            var employeeName = order.Employee.Name;
            
            _db.Add(obj);
            _db.SaveChanges();
            return View();
        }
    }
}