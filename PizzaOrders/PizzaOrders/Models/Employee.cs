using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaOrders.Models
{
    public class Employee 

    {
    [Key] //primary key- attribute
    public int EmployeeId { get; set; }

    public string Name { get; set; }

    [DisplayName("Dep")]
    //this TAG helper will be the display
    public string Department { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
    }
}