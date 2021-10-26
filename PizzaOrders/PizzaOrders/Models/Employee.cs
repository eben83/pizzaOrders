using System.ComponentModel.DataAnnotations;

namespace PizzaOrders.Models
{
    public class Employee
    {
        [Key]//primary key- attribute
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }
    }
}