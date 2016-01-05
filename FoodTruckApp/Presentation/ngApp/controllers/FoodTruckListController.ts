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
                .then(() => {
                    for (let truck of this.foodTrucks) {
                        truck.rating = truck.reviews.reduce(function (prev, curr) { return prev + curr.starRating }, 0) / truck.reviews.length;
                    }
                })
        }

        public goToMap()
        {
            this.$location.path('/map');
        }

        public goToFoodTruck(id)
        {
            this.$location.path(`/description/${id}`);

        }

    }
}