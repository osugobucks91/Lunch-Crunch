using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Domain.Models {
    public class Review {

        public int Id { get; set; }

        public int StarRating { get; set; }

        public string Message { get; set; }

        public FoodTruck TruckId { get; set; }
    }
}
