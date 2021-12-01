using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        
        
        //GET - EDIT
        public ActionResult Edit(int Id)
        {
            //the ID- passed in from the ASP-ROUTE-ID tag helper
            
            //this just checks if the id is not null or 0
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            
            //get the data from the db, this will just find the employee with the id that was passed in
            var employee = _db.Employees.Find(Id);
            
            // you can do another check to see if the record was found or not
            if (employee == null)
            {
                return NotFound();
            }
            
            //if the record was found, return that to the view
            return View(employee);

        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Update(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);

        }
        
        
        
        //GET- DELETE
        public ActionResult Delete(int? Id)
        {
            //the ID- passed in from the ASP-ROUTE-ID tag helper on the index page
            
            //get the data from the db, this will just find the employee with the id that was passed in
            var employee = _db.Employees.Find(Id);
            
            // you can do another check to see if the record was found or not
            if (employee == null)
            {
                return NotFound();
            }
            
            //if the record was found, return that to the view
            //return View(employee);
            
            _db.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //This is not working????
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmployee(int? id)
        {
            var employee = _db.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }
            _db.Remove(employee.EmployeeId);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}