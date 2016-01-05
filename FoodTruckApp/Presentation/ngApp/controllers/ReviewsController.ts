namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    export class ReviewsController {

        public foodTruck: FoodTruck;

        constructor(private $http, private $location, private $routeParams) {
            $http.get('/api/foodtrucks/' + $routeParams['id'])
                .then((response) => {
                    this.foodTruck = response.data;
                })
                .then(() => {
                    this.foodTruck.rating = this.foodTruck.reviews.reduce(function (prev, curr) { return prev + curr.starRating }, 0) / this.foodTruck.reviews.length;
                });
        }
    }

}