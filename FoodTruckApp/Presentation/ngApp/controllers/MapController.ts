namespace FoodTruckApp.Controllers {

    export class MapController {
        constructor(private $http, private $location, private $routeParams) {

            this.$location = $location;

        }
        
        public goToList() {
            this.$location.path('/list');
        }

    }
}