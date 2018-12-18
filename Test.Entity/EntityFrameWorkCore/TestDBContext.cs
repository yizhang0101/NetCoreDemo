using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Core.User;

namespace Test.EntityFramworkCore.EntityFrameWorkCore
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationBuilder()
            //            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //var configuration = builder.Build();

            //string connectionString = configuration.GetConnectionString("MyConnection");
            string connectionString = "server=140.143.0.226;database=TestDb;user=root;password=zy09831983";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Sets the properties that make up the primary key for this entity type.
            builder.Entity<User>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
