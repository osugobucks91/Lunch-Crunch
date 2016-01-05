namespace FoodTruckApp.Controllers
{
    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    export class FoodTruckDescriptionController
    {

        public foodTruck: FoodTruck;

        constructor(private $http, private $location, private $routeParams)
        {
            $http.get('/api/foodtrucks/' + $routeParams['id'])
                .then((response) => {
                    this.foodTruck = response.data;
                });
        }
    }
}