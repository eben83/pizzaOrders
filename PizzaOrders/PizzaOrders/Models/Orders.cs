using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaOrders.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateTime { get; set; }
        
        [DisplayName("Employee Name")]
        public Employees Name { get; set; }

        public string Pizza { get; set; }

        public string Drink { get; set; }
        
        
    }
}