
using CleanEntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanEntityFramework.Context
{
    public class Context : DbContext
    {
        public DbSet<FirstEntity> Elements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OurDataBase;Trusted_Connection=true;");
        }
    }
}