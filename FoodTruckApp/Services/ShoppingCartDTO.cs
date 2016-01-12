using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Services {
    public class ShoppingCartDTO {

        public int Id { get; set; }

        public MenuItemDTO Item { get; set; }

        public ApplicationUserDTO Owner { get; set; }
    }
}