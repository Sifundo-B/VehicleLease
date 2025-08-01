namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "WebApplication1.Models.ApplicationDbContext";
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            // Avoid reseeding if data already exists
            //if (context.Suppliers.Any()) return;

            // ---- Seed Suppliers ----
            var supplier1 = new Supplier { Name = "AutoFleet Pty Ltd" };
            var supplier2 = new Supplier { Name = "Metro Vehicles Ltd" };
            context.Suppliers.AddOrUpdate(s => s.Name, supplier1, supplier2);

            // ---- Seed Branches ----
            var branch1 = new Branch { Name = "Johannesburg HQ" };
            var branch2 = new Branch { Name = "Durban Depot" };
            context.Branches.AddOrUpdate(b => b.Name, branch1, branch2);

            // ---- Seed Clients ----
            var client1 = new Client { CompanyName = "LogiTrans Inc" };
            var client2 = new Client { CompanyName = "Silverline Rentals" };
            context.Clients.AddOrUpdate(c => c.CompanyName, client1, client2);

            // ---- Seed Drivers ----
            var driver1 = new Driver { FullName = "Andile Ndlovu" };
            var driver2 = new Driver { FullName = "Thabiso Mokoena" };
            context.Drivers.AddOrUpdate(d => d.FullName, driver1, driver2);

            context.SaveChanges(); 

            // ---- Seed Vehicles ----
            var vehicle1 = new Vehicle
            {
                Manufacturer = "Toyota",
                Model = "Corolla",
                ProcuredDate = new DateTime(2025, 5, 10), 
                SupplierId = supplier1.SupplierId,
                BranchId = branch1.BranchId,
                ClientId = client1.ClientId,
                DriverId = driver1.DriverId
            };

            var vehicle2 = new Vehicle
            {
                Manufacturer = "Ford",
                Model = "Ranger",
                ProcuredDate = new DateTime(2025, 1, 15), 
                SupplierId = supplier2.SupplierId,
                BranchId = branch2.BranchId,
                ClientId = client2.ClientId,
                DriverId = driver2.DriverId
            };


            context.Vehicles.AddOrUpdate(
                v => new { v.Manufacturer, v.ClientId }, 
                vehicle1,
                vehicle2
            );

            context.SaveChanges(); 
        }

    }
}
