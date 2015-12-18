namespace FoodTruckApp {
    angular.module("FoodTruckApp", ['ngRoute'])
        .config(function ($routeProvider) {
            $routeProvider
                .when('/', {
                    template: '<p>Hello World</p>'
                });
        });
}