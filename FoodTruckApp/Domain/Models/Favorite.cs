using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Domain.Models
{
    public class Favorite
    {

        public int Id { get; set; }

        public ApplicationUser CustomerUserName { get; set; }

        public FoodTruck FoodTruck { get; set; }

    }
}
