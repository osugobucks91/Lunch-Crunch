namespace FoodTruckApp.Controllers {

    //one more time
    export class HomeController {

        constructor(public $http, private $location) {

        }

        public goToBussinessLogin() {

            this.$location.path(`/business/login`);

        }

        public goToCustomerLogin() {

            this.$location.path(`/customer/login`);

        }

    }

}