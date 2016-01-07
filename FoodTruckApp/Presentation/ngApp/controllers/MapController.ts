namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    export class MapController {

        public foodTrucks: FoodTruck[];

        public map;

        constructor(private $http, private $location, private $routeParams) {

            this.$location = $location;

            $http.get('/api/foodtrucks')
                .then((response) => {
                    this.foodTrucks = response.data;
                })

        }

        
    }

    
}