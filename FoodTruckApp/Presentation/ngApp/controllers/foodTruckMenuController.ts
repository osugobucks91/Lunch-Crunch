namespace FoodTruckApp.Controllers {

    import Truck = FoodTruckApp.Models.FoodTruck;

    import ShoppingCart = FoodTruckApp.Models.ShoppingCart;

    import MenuItem = FoodTruckApp.Models.MenuItem;

    export class FoodTruckMenuController {

        public truck: Truck;

        public newCartItem: ShoppingCart = new ShoppingCart();

        public menuItem: MenuItem;

        public validationErrors;

        constructor(private $http, private $location, private $routeParams) {

            $http.get(`/api/foodtrucks/${$routeParams['id']}`)
                .then((response) => {
                    this.truck = response.data;
                })
        }

        public goToDescription(id: number) {
            this.$location.path(`/description/${this.truck.id}`);
        }

        public goToMenu(id: number) {
            this.$location.path(`/menu/${this.truck.id}`);
        }

        public goToReview(id: number) {
            this.$location.path(`/review/${this.truck.id}`);
        }

        public goToShoppingCart(id: number) {
            this.$location.path(`/shoppingcart`);
        }

        public addToCart(id: number) {

            this.newCartItem.item = new MenuItem();
            this.newCartItem.item.id = id;
            this.$http.post('/api/shoppingCart', this.newCartItem)
                .then((response) => {
                    this.newCartItem = new ShoppingCart();
                })
                .catch((response) => {
                    this.validationErrors = [];
                    let modelState = response.data.modelState;
                    for (let error in modelState) {
                        this.validationErrors = this.validationErrors.concat(modelState[error]);
                    }
                })
        }
    }
}