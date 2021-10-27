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

        //this prop will push to the db
        public DbSet<Employees> Employees { get; set; }
    }
}