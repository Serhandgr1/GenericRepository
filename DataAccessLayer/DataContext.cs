using Microsoft.EntityFrameworkCore;
using DataAccessLayer;

namespace DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
       
        public DbSet<ModelMigration> Models { get; set; }
    }
}
