namespace FoodTruckApp.Controllers {

    //one more time
    export class HomeController {

        constructor(public $http, private $location) {

        }

        public goToBussinessLogin() {

            this.$location.path(`/businesslogin`);

        }

        public goToCustomerLogin() {

            this.$location.path(`/customerlogin`);

        }

    }

}