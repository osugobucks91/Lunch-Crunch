using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Domain.Models {
    public class ShoppingCart {

        public int Id { get; set; }

        public MenuItem Item { get; set; }

        public ApplicationUser Owner { get; set; }
    }
}