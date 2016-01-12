namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    import Review = FoodTruckApp.Models.Review;

    export class ReviewsController {

        public foodTruck: FoodTruck;

        public newReview: Review;

        public validationErrors;

        constructor(private $http, private $location, private $routeParams) {
            $http.get('/api/foodtrucks/' + $routeParams['id'])
                .then((response) => {
                    this.foodTruck = response.data;
                })
                .then(() => {
                    this.foodTruck.rating = this.foodTruck.reviews.reduce(function (prev, curr) { return prev + curr.starRating }, 0) / this.foodTruck.reviews.length;
                });
        }

        public addReview(truckId:number)
        {
            this.newReview.id = truckId;

            this.$http.post('/api/reviews', this.newReview)
                .then((response) => {
                    this.newReview = null;
                    
                })
                .catch((response) => {
                    this.validationErrors = [];

                    let modelState = response.data.modelState;
                    for (let error in modelState) {
                        this.validationErrors = this.validationErrors.concat(modelState[error]);
                    }
                })
                .then(() =>
                {
                    this.$location.path('/reviews/' + this.$routeParams['id']);
                    this.$location.reload();
                }
            )

        }

    }

}