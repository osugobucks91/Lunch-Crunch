using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodTruckApp.Services
{
    [RoutePrefix("api/orders")]
    public class FoodTrucksController : ApiController
    {

        private FoodTruckService _foodTruckService;

        public FoodTrucksController(FoodTruckService _foodTruckService)
        {
            _foodTruckService = FoodTruckService;
        }

        [HttpGet]
        public IList<FoodTruckDTO> Get()
        {
            return _foodTruckService.List(User.Identity.Name);
        }

        [HttpPost]
        public IHttpActionResult Post()
        {
           
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);

            }

            _foodTruckService.CreateFoodTruck(User.Identity.Name);
            return Ok();

        }

    }
}
