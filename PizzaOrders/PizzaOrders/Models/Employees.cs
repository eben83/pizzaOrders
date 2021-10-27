using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaOrders.Models
{
    public class Employees
    {
        [Key]//primary key- attribute
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("Dep")]
        //this TAG helper will be the display
        public string Department { get; set; }
    }
}