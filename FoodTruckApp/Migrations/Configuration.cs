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

            var foodTrucks = new FoodTruck[]
            {
                new FoodTruck
                {
                    Id=1,
                    Name = "Bely Up",
                    Image = "https://www.foodtrucksin.com/sites/default/files/styles/truck_food_gallery/public/20150429_110901.jpg?itok=ur2nK19w",
                    Description = "Belly Up is proud to serve American cuisine with ethnic twists",
                    Location = "1234 Montrose St, Houston, TX 77019"
                },
                new FoodTruck
                {
                    Id=2,
                    Name = "Dasman",
                    Image = "https://pbs.twimg.com/media/CTLgksaUYAAKdNT.jpg",
                    Description = "A Taste of the Mediterranean. Bringing you Authentic Mediterranean Shawarma wraps",
                    Location = "2220 Brazos St, Houston, TX 77002"
                },
                new FoodTruck
                {
                    Id=3,
                    Name = "St.Johns Fire",
                    Image = "https://pbs.twimg.com/media/CRsABfQVAAA-FFE.jpg",
                    Description = "Seafood, Cajun/Creole, Mac 'n Cheese",
                    Location = "1500 Hermann Dr, Houston, TX 77004"
                },
                new FoodTruck
                {
                    Id=4,
                    Name = "Bernie's Bus",
                    Image = "https://pbs.twimg.com/media/CLU2nOJUAAAq8mT.jpg",
                    Description = "Serving homemade tasty burgers, hand cut fries, as well as all homemade condiments",
                    Location = "6355 Clara Rd, Houston, TX 77041"
                },
                new FoodTruck
                {
                    Id=5,
                    Name = "Skratch Food Truck",
                    Image = "https://scontent-dfw1-1.xx.fbcdn.net/hphotos-xfp1/v/t1.0-9/12347858_1045443922188255_7182050856081769376_n.jpg?oh=20b3ba58eca6688bad04055b1e608ee2&oe=5714BAAD",
                    Description = "Eclectic food on the go with some Texas flair and locally grown ingredients",
                    Location = "1 Reliant Pkwy Houston, TX 77054"
                },
                new FoodTruck
                {
                    Id=6,
                    Name = "The Waffle Bus",
                    Image = "http://houstonstop100foodtrucks.com/wp-content/gallery/houstons-top-100-food-trucks/dscn2140.jpg",
                    Description = "Waffles, Wings, Sandwiches",
                    Location = "1953 Montrose, TX 77019 "
                }
            };


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
