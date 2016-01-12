namespace FoodTruckApp.Models {

    export class MenuItem {

        public id: number;
        public name: string;
        public price: number;
        public description: string;
        public imageUrl: string;
        public owner;
        public truckID: FoodTruck;
    }
}