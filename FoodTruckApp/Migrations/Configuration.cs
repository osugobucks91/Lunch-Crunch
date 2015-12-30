namespace FoodTruckApp.Migrations {
    using Domain.Models;
    using Infrastructure;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            var test = userManager.FindByName("Test");

            if (test == null) {
                test = new ApplicationUser() {
                    UserName = "test",
                    Email = "test@test.com"
                };
                userManager.Create(test, "Password!1");
            }

            var business = userManager.FindByName("business@business.com");

            if (business == null)
            {
                business = new ApplicationUser()
                {
                    UserName = "business@business.com",
                    Email = "business@business.com",
                };
                userManager.Create(business, "Password!1");
            };
            context.SaveChanges();

        }
    }
}
