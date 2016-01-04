namespace FoodTruckApp.Controllers {

    import Customer = FoodTruckApp.Models.ApplicationUser;

    export class CustomerRegisterController {

        public newCustomer: Customer;
        public validationErrors;

        constructor(private $http, private $window, private $location) { }

        public register() {

            this.$http.post('/api/account/register', this.newCustomer)
                .then((response) => {
                    this.$location.path('/customer/login');
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