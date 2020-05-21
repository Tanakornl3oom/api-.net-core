using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using test_project_api.Enitity.models;

namespace test_project_api.Enitity
{
    public class UserContext : DbContext
    {
      
        public DbSet<User> users {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql("User ID = postgres;Host=localhost;Port=5432;Database=test_project;Password=postgres;");
    }
}