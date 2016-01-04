namespace FoodTruckApp.Models {

    export class FoodTruck {

        public id: number;

        public name: string;

        public image: string;

        public description: string;

        public menuItems: MenuItem[];

        public location: string;

        public reviews: Review[];

        public owner;

        public category: string;
    }
}