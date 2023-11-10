using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCodeFirst
{
    //Declare Category Entity
    public class Category
    {
        public Category() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }//end Categories

    public class MyStock : DbContext
    {
        public MyStock() { }
        //These properties map to tables in the database
        public DbSet<Category> Categories { get; set; }
        protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyStockDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Using Fluent API instead of attributes
            //to limit the length of a CategoryName to under 40
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired() //NOT NULL
                .HasMaxLength(40);
            //Insert data for Categories table
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Beverages" },
                new Category { CategoryID = 2, CategoryName = "Condiments" },
                new Category { CategoryID = 3, CategoryName = "Confections" }
            );
        }
    }//end MyStock class
}