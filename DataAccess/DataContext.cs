using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OdevDb;TrustServerCertificate=true;Trusted_Connection=True;");
        }
            public DbSet<ModelsModel> Models { get; set; }
            public DbSet<Car> Cars { get; set; }
    }
}
