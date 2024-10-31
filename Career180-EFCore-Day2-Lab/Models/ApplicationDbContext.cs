using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Career180_EFCore_Day2_Lab.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Server = .; Database = Career180Ef2Lab; Trusted_Connection = true; TrustServerCertificate = true;");
    }
}
