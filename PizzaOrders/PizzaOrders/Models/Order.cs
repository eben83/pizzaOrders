using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaOrders.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Date Time")]
        public DateTime DateTime { get; set; }
        
        public string Pizza { get; set; }

        public string Drink { get; set; }
        
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public void Test()
        {
            var employeeName = Employee.Name;
            Employee = new Employee();
        }
    }
}