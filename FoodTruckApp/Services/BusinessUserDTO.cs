using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Services {
    class BusinessUserDTO {

        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public IList<FoodTruckDTO> FoodTrucks { get; set; }
    }
}
