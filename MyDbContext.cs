using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_with_Entity_Framework
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AssetTracking;Integrated Security=True";

        // it will create the table and name of the table will be Users

        public DbSet<Office> Offices { get; set; }
        public DbSet<Asset> Assets { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Office>().HasData(new Office { Id = 1, Name = "Skövde", Currency = "SEK", ConversionRate = 10.54f });
            ModelBuilder.Entity<Office>().HasData(new Office { Id = 2, Name = "Boston", Currency = "USD", ConversionRate = 1 });
            ModelBuilder.Entity<Office>().HasData(new Office { Id = 3, Name = "Paris", Currency = "EUR", ConversionRate = 0.92f });

            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 1, Type = "Phone", Model="Iphone 8", PurchaseDate = DateTime.Parse("2024-02-05"), OfficeId = 1, Price = 500 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 2, Type = "Phone", Model="Samsung Galaxy", PurchaseDate = DateTime.Parse("2023-02-05"), OfficeId = 2, Price = 300 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 3, Type = "Phone", Model="OnePlus", PurchaseDate = DateTime.Parse("2021-05-02"), OfficeId = 3, Price = 200 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 4, Type = "Phone", Model="Nokia 3310", PurchaseDate = DateTime.Parse("2002-01-26"), OfficeId = 2, Price = 60 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 5, Type = "Laptop", Model="Macbooc Air", PurchaseDate = DateTime.Parse("2021-08-18"), OfficeId = 3, Price = 800 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 6, Type = "Laptop", Model="Asus TUF Dash", PurchaseDate = DateTime.Parse("2023-05-01"), OfficeId = 1, Price = 800 });
            ModelBuilder.Entity<Asset>().HasData(new Asset { Id = 7, Type = "Laptop", Model="Lenovo Thinkpad", PurchaseDate = DateTime.Parse("2021-04-20"), OfficeId = 2, Price = 800 });


        }
    }
}
