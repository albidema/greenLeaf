using GreenLeafApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenLeafApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {  }

        public DbSet<Value> Values { get; set; }
    }
}