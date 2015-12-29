namespace FoodTruckApp.Models {

    export class MenuItem {

        public id: string;
        public name: string;
        public price: number;
        public description: string;
        public image: string;      //should be optional
        public owner;
    }
}