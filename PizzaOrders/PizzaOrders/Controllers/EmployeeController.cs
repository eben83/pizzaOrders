using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaOrders.Data;
using PizzaOrders.Models;

namespace PizzaOrders.Controllers
{
    public class EmployeeController : Controller
    {
        //prop 
        private readonly ApplicationDbContext _db;

        //ctor- to populate the above prop 
        //this will pull from the DbContext container
        //you can just add the Class or Interface as a parameter with a name
        public EmployeeController(ApplicationDbContext db)
        {
            //local _db will be assigned to the DbContext
            //(ApplicationDbContext db) object will have an instance of the DbContext
            //_db will now be available throughout the controller
            _db = db;
        }
        public IActionResult Index()
        {
            //making an IEnumerable to display the list of Employee
            //
            IEnumerable<Employee> objectList = _db.Employees;
            return View(objectList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }
        
        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            _db.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}