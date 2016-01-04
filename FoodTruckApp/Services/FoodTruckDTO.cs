using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Services {
    public class FoodTruckDTO {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public IList<MenuItemDTO> MenuItems { get; set; }

        public string Location { get; set; }

        public IList<ReviewDTO> Reviews { get; set; }

        public ApplicationUserDTO BusinessOwner { get; set; }

        public string Category { get; set; }
    }
}
