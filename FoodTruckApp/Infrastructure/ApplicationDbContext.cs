using FoodTruckApp.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Infrastructure {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();
        }

        public IDbSet<FoodTruck> FoodTrucks { get; set; }

        public IDbSet<MenuItem> MenuItems { get; set; }

        public IDbSet<Review> Reviews { get; set; }

        public IDbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}