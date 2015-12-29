namespace FoodTruckApp {
    angular.module("FoodTruckApp", ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
                .when('/', {
                    templateUrl: '/presentation/ngApp/views/home.html',
                    controller: FoodTruckApp.Controllers.HomeController,
                    controllerAs: 'home'
                });
        });
}