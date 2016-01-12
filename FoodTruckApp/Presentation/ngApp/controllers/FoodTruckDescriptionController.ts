namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    export class FoodTruckDescriptionController
    {

        public foodTruck: FoodTruck;

        constructor(private $http, private $location, private $routeParams)
        {
            $http.get('/api/foodtrucks/' + $routeParams['id'])
                .then((response) =>
                {
                    this.foodTruck = response.data;
                })
                .then(() =>
                {
                    this.foodTruck.rating = this.foodTruck.reviews.reduce(function (prev, curr) { return prev + curr.starRating }, 0) / this.foodTruck.reviews.length;
                });
        }

        public goToDescription(id: number) {
            this.$location.path(`/description/${this.foodTruck.id}`);
        }

        public goToMenu(id: number) {
            this.$location.path(`/menu/${this.foodTruck.id}`);
        }

        public goToReview(id: number) {
            this.$location.path(`/review/${this.foodTruck.id}`);
        }
    }
}