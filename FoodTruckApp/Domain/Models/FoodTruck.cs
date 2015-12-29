﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Domain.Models {
    class FoodTruck {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public IList<MenuItem> MenuItems { get; set; }

        public string Location { get; set; }

        public IList<Review> Reviews { get; set; }

        public ApplicationUser BusinessOwner { get; set; }
    }
}