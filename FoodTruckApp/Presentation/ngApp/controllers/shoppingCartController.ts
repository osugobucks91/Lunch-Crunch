namespace FoodTruckApp.Controllers {

    import ShoppingCart = FoodTruckApp.Models.ShoppingCart;

    export class ShoppingCartController {

        public cartItems: ShoppingCart[];

        private $http;
        private $location;

        constructor($http, $location) {

            this.$http = $http;
            this.$location = $location;

            $http.get(`/api/shoppingCart`)
                .then((response) => {
                    this.cartItems = response.data;
                });
        }

        public goToMenu(id: number) {
            this.$location.path(`/menu/${id}`);
        }

        public deleteShoppingCartItem(id: number) {
            this.$http.delete(`/api/shoppingCart/${id}`)
                .then((response) => {
                    window.location.reload(false);
                })
        }
    }
}