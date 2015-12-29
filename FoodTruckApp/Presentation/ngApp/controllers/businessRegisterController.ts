namespace FoodTruckApp.Controllers {

    import Business = FoodTruckApp.Models.BusinessUser;

    export class BusinessRegisterController {

        public newBusiness: Business;
        public validationErrors;

        constructor(private $http, private $window, private $location) { }

        public register() {

            this.$http.post('/api/Account/Register', this.newBusiness)
                .then((response) => {
                    this.$location.path('/business/create');
                    this.newBusiness = null;
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
            this.$location.path('/business/login');
        }
    }
}