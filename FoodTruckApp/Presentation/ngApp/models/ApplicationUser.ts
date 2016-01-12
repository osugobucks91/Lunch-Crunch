﻿namespace FoodTruckApp.Models {

    export class ApplicationUser {

        public id: string;

        public userName: string;

        public email: string;

        public password: string;

        public cartItem: ShoppingCart[];
    }
}