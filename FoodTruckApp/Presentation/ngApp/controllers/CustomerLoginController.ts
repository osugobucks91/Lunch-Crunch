﻿namespace FoodTruckApp.Controllers {

    export class CustomerLoginController {

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
                    this.loginMessage = 'Invalid username or password';
                });
        }

        public logout() {
            this.$window.localStorage.removeItem('token');
            this.$location.path('/customer/login');
        }

        public isLoggedIn() {
            return this.$window.localStorage.getItem('token');
        }

        public goToRegister() {
            this.$location.path('/customer/register');
        }
    }
    angular.module('FoodTruckApp').controller('loginController', CustomerLoginController);
}