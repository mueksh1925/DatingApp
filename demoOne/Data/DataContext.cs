using demoOne.Models;
using Microsoft.EntityFrameworkCore;
namespace demoOne.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
        public DbSet<Value> Values{get;set;}
    }
}