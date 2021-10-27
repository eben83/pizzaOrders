using Microsoft.EntityFrameworkCore;
using PizzaOrders.Models;

namespace PizzaOrders.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Ctor- to create the constructor
        //then using the DbContext Options to configure the DbContext Class
        //and passing in the application db context with the options
        //to the base Class of DbContext
        //this will also pass in the connection string
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        //This prop represents a table in the db or some other form of a collection of records of type
        //Employee depending on the type of DB Engine :D
        public DbSet<Employees> Employees { get; set; }
    }
}