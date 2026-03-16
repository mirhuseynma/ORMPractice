using Microsoft.EntityFrameworkCore;
using ORM.Practice.Models;

namespace ORM.Practice.Data
{
    internal class AppDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Student;Trusted_Connection=True;");
        }
    }
}
