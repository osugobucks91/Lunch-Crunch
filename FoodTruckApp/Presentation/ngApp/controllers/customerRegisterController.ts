namespace FoodTruckApp.Controllers {

    import Customer = FoodTruckApp.Models.CustomerUser;

    export class RegisterController {

        public newCustomer: Customer;
        public validationErrors;

        constructor(private $http, private $window, private $location) { }

        public register() {

            this.$http.post('/api/account/register', this.newCustomer)
                .then((response) => {
                    this.$location.path('/customer');
                    this.newCustomer = null;
                })
                .catch((response) => {
                    this.validationErrors = [];
                    let modelState = response.data.modelState;
                    for (let error in modelState) {
                        this.validationErrors = this.validationErrors.concat(modelState[error]);
                    }
                })
        }

        public goToLogin() {
            this.$location.path('/customer/login');
        }
    }
}