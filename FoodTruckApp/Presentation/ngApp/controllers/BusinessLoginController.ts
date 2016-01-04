﻿namespace FoodTruckApp.Controllers {

    export class BusinessLoginController {

        public username: string;

        public password: string;

        public loginMessage: string;

        constructor(private $http, private $window, private $location) { }

        public login() {

            let data = `grant_type=password&username=${this.username}&password=${this.password}`;

            this.$http.post('/token', data, {
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            })
                .then((response) => {
                    this.$window.localStorage.setItem('token', response.data['access_token']);
                    this.$location.path('/map');
                })
                .catch((response) => {
                    this.loginMessage = 'invalid username or password';
                });
        }
    }
    angular.module("FoodTruckApp").controller("businessAuthController", BusinessLoginController);

}

