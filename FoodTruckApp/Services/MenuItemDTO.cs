using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Services {
    public class MenuItemDTO {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } 
        public ApplicationUserDTO BusinessOwner { get; set; }
        public FoodTruckDTO TruckID { get; set; }
    }
}
