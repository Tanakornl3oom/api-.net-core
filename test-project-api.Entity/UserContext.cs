﻿using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using test_project_api.Entity.models;

namespace test_project_api.Entity
{
    public class UserContext : DbContext 
    {

        public DbSet<User> users {get; set;}
        public DbSet<Role> roles {get; set;}
        public DbSet<UsersRole> UsersRoles { get; set; }
        public IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql((DbConnection)DatabaseContext.Instance);

    }
}