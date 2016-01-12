﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Services {
    public class ApplicationUserDTO {

        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public IList<ShoppingCartDTO> cartItem { get; set; }
    }
}
