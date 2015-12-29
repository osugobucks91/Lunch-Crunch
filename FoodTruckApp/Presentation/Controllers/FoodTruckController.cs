using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodTruckApp.Services
{
    [RoutePrefix("api/foodtruck")]
    public class FoodTrucksController : ApiController
    {

        private FoodTruckService _foodTruckService;

        public FoodTrucksController(FoodTruckService foodTruckService)
        {
            _foodTruckService = foodTruckService;
        }

        public IHttpActionResult Post(FoodTruckDTO newFoodTruck)
        {
           
            if (ModelState.IsValid)
            {
                newFoodTruck.BusinessOwner = new BusinessUserDTO() {
                    UserName = User.Identity.Name
                };
                _foodTruckService.AddNewFoodTruck(newFoodTruck);
                return Ok();
            }

            else {
                return BadRequest(ModelState);
            }
        }

    }
}
