namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    export class FoodTruckListController {

        public foodTrucks: FoodTruck[];

        constructor(private $http, private $location, private $routeParams) {

            this.$location = $location;

            $http.get('api/foodtrucks')
                .then((response) => {
                    this.foodTrucks = response.data;
                })
                .then(() => {
                    for (let truck of this.foodTrucks) {
                        truck.rating = truck.reviews.reduce(function (prev, curr) { return prev + curr.starRating }, 0) / truck.reviews.length;
                    }
                })
                .then(() =>
                {
                    this.foodTrucks[0].image = "../Content/bellyup.png";
                    this.foodTrucks[1].image = "../Content/dasman.png";
                    this.foodTrucks[2].image = "../Content/stjohnsfire.png";
                    this.foodTrucks[3].image = "../Content/berniesbus.png";
                    this.foodTrucks[4].image = "../Content/skratch.png";
                    this.foodTrucks[5].image = "../Content/wafflebus.png";

                })

        }

        public goToMap()
        {
            this.$location.path('/map');
        }

        public goToFoodTruck(id)
        {
            this.$location.path(`/description/${id}`);

        }

    }
}