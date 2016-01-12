namespace FoodTruckApp.Models {

    export class ShoppingCart {

        public id: number;

        public item: MenuItem;

        public owner: ApplicationUser;
    }
}