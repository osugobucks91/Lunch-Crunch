namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    export class FoodTruckListController {

        public foodTrucks: FoodTruck[];

        constructor(private $http, private $location, private $routeParams) {

            this.$location = $location;

            $http.get('api/foodtrucks')
                .then((response) => {
                    this.foodTrucks = response.data;
                })
        }

        public goToMap() {
            this.$location.path('/map');
        }
    }
}