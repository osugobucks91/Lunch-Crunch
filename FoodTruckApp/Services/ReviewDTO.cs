using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Services {
    public class ReviewDTO {

        public int Id { get; set; }

        public int StarRating { get; set; }

        public string Message { get; set; }

        public FoodTruckDTO TruckId { get; set; }
    }
}
