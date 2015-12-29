namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    export class BusinessCreateController {

        public newFoodTruck: FoodTruck;
        public validationErrors;

        constructor(private $http, private $window, private $location) { }

        public businessCreate() {

            this.$http.post('/api/foodtruck', this.newFoodTruck)
                .then((response) => {
                    this.$location.path('/business');
                    this.newFoodTruck = null;
                })
                .catch((response) => {
                    this.validationErrors = [];
                    let modelState = response.data.modelState;
                    for (let error in modelState) {
                        this.validationErrors = this.validationErrors.concat(modelState[error]);
                    }
                })

        }

    }

}