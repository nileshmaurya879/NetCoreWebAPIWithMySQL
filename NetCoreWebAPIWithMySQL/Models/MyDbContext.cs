

using Microsoft.EntityFrameworkCore;

namespace NetCoreWebAPIWithMySQL.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<tbltest> tbltest    { get; set; } 
    }
}
