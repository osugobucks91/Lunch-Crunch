﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Domain.Models {
    public class MenuItem {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }                 
        
        public FoodTruck FoodTruck { get; set; }

    }
}