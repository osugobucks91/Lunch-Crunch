namespace FoodTruckApp {
    angular.module("FoodTruckApp", ['ngRoute', 'uiGmapgoogle-maps']);

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
        .config(function ($routeProvider, $httpProvider, uiGmapGoogleMapApiProvider) {
            $routeProvider
                .when('/', {
                    templateUrl: '/presentation/ngApp/views/home.html'
                })
                .when('/about', {
                    templateUrl: '/presentation/ngApp/views/about.html',
                })
                .when('/contact', {
                    templateUrl: '/presentation/ngApp/views/contact.html'
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
                    controller: FoodTruckApp.Controllers.FoodTruckMenuController,
                    controllerAs: 'menu'
                })
                .when('/reviews/:id', {
                    templateUrl: '/presentation/ngApp/views/reviews.html',
                    controller: FoodTruckApp.Controllers.ReviewsController,
                    controllerAs: 'review'
                })
                .when('/shoppingcart', {
                    templateUrl: '/presentation/ngApp/views/shoppingCart.html',
                    controller: FoodTruckApp.Controllers.ShoppingCartController,
                    controllerAs: 'cart'
                })
                .when('/payment', {
                    templateUrl: '/presentation/ngApp/views/payment.html'
                })
                .when('/ordercomplete', {
                    templateUrl: '/presentation/ngApp/views/orderComplete.html'
                })

            $httpProvider.interceptors.push('authInterceptor');


            angular.module('FoodTruckApp', ['uiGmapgoogle-maps']).config((uiGmapGoogleMapApiProvider: any) => {
                uiGmapGoogleMapApiProvider.configure({
                    //    key: 'your api key',
                    v: '3.20', //defaults to latest 3.X anyhow
                    libraries: 'places' // Required for SearchBox
                });

            });

        });




}