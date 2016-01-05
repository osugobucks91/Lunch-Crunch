using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodTruckApp.Services
{
    [RoutePrefix("api/foodtrucks")]
    public class FoodTrucksController : ApiController
    {

        private FoodTruckService _foodTruckService;

        public FoodTrucksController(FoodTruckService foodTruckService)
        {
            _foodTruckService = foodTruckService;
        }

        //Get a List of food trucks for list view
        public IList<FoodTruckDTO> Get() {
            return _foodTruckService.List();
        }

        //Add a new food truck
        public IHttpActionResult Post(FoodTruckDTO newFoodTruck)
        {
           
            if (ModelState.IsValid)
            {
                //newFoodTruck.BusinessOwner = new ApplicationUserDTO() {
                //    UserName = User.Identity.Name
                //};
                _foodTruckService.AddNewFoodTruck(newFoodTruck);
                return Ok();
            }

            else {
                return BadRequest(ModelState);
            }
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {

            var foodTruck = _foodTruckService.FindById(id); 

            if (foodTruck != null)
            {
                return Ok(foodTruck);
            }
            return BadRequest();
            
        }
    }
}
