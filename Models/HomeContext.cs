using Microsoft.EntityFrameworkCore;
 
namespace cwdmap.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Processor> Processors { get;set;}
        //         ^model^ ^table name^
    }
}