using System.Data.Entity;


namespace VSR.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext()
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
