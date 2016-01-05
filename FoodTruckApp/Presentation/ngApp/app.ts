namespace FoodTruckApp {
    angular.module("FoodTruckApp", ['ngRoute']);

    angular.module("FoodTruckApp").factory('authInterceptor',
        ($q: ng.IQService, $window: ng.IWindowService, $location: ng.ILocationService) => {
            return {
                request: (config) => {
                    config.headers = config.headers || {};
                    let token = $window.localStorage.getItem('token');
                    if (token) {
                        config.headers.Authorization = `Bearer ${token}`;
                    }
                    return config;
                },
                responseError: (response) => {
                    if (response.status === 401) {
                        $location.path('/customer/login');
                    }
                    return response || $q.when(response);
                }
            }
        });

    angular.module("FoodTruckApp")
        .config(function ($routeProvider, $httpProvider) {
            $routeProvider
                .when('/', {
                    templateUrl: '/presentation/ngApp/views/home.html',
                    controller: FoodTruckApp.Controllers.HomeController,
                    controllerAs: 'home'
                })
                .when('/customer/login', {
                    templateUrl: '/presentation/ngApp/views/customerLogin.html',
                    controller: FoodTruckApp.Controllers.CustomerLoginController,
                    controllerAs: 'custLogin'
                })
                .when('/customer/register', {
                    templateUrl: '/presentation/ngApp/views/customerRegister.html',
                    controller: FoodTruckApp.Controllers.CustomerRegisterController,
                    controllerAs: 'custRegister'
                })
                .when('/business/login', {
                    templateUrl: '/presentation/ngApp/views/businessLogin.html',
                    controller: FoodTruckApp.Controllers.BusinessLoginController,
                    controllerAs: 'businessLogin'
                })
                .when('/business/register', {
                    templateUrl: '/presentation/ngApp/views/businessRegister.html',
                    controller: FoodTruckApp.Controllers.BusinessRegisterController,
                    controllerAs: 'businessRegister'
                })
                .when('/map', {
                    templateUrl: '/presentation/ngApp/views/map.html',
                    controller: FoodTruckApp.Controllers.MapController,
                    controllerAs: 'map'
                })
                .when('/list', {
                    templateUrl: '/presentation/ngApp/views/list.html',
                    controller: FoodTruckApp.Controllers.FoodTruckListController,
                    controllerAs: 'list'
                })
                .when('/description/:id', {
                    templateUrl: '/presentation/ngApp/views/description.html',
                    controller: FoodTruckApp.Controllers.FoodTruckDescriptionController,
                    controllerAs: 'ftc'
                })
                .when('/menu/:id', {
                    templateUrl: '/presentation/ngApp/views/menu.html',
                    controller: FoodTruckApp.Controllers.FoodTruckDescriptionController,
                    controllerAs: 'ftc'
                })
                .when('/reviews/:id', {
                    templateUrl: '/presentation/ngApp/views/reviews.html',
                    controller: FoodTruckApp.Controllers.FoodTruckDescriptionController,
                    controllerAs: 'ftc'
                })
            $httpProvider.interceptors.push('authInterceptor');
        });
}