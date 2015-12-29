namespace FoodTruckApp.Models {

    export class Review {

        public id: number;

        public starRating: number;

        public message: string;

        public customerUserName;

        public businessOwner;

        public truckId: FoodTruck;
    }
}