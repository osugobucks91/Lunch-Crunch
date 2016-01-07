namespace FoodTruckApp.Controllers {

    import GeoCoder = google.maps.Geocoder;

    class GoogleMapController {
        public center = { latitude: 29.75, longitude: -95.377044 };
        public zoom = 10;

        public addresses = ['2220 Brazos St, Houston, TX 77002', '6355 Clara Rd, Houston, TX 77041', '1 Reliant Pkwy Houston, TX 77054', '1953 Montrose, TX 77019', '11308 W Broadway St, Pearland, TX 77584'];

        public geoCoder: GeoCoder;

        public markers = [
            {
                id: 0,
                title: 'Test',
                options: {
                    title: 'BellyUp',
                    
                },

                latitude: 29.556014,
                longitude: -95.386004
            },
            {
                id: 1,
                options: {
                    title: 'Dasman',
                    
                },
                latitude: 29.750165,
                longitude: -95.377044
            },
            {
                id: 2,
                options: {
                    title: 'St. Johns Fire',
                    
                },
                latitude: 29.721724,
                longitude: -95.387036
            },
            {
                id: 3,
                options: {
                    title: "Bernie's Bus",
                    
                },
                latitude: 29.861023,
                longitude: -95.554351
            },
            {
                id: 4,
                options: {
                    labelContent: 'Skratch Food Truck',
                    labelAnchor: '26 0',
                    labelClass: 'labels'
                },
                latitude: 29.685072,
                longitude: -95.411090
            },
            {
                id: 5,
                options: {
                    title: 'The Waffle Bus',
                    
                },
                
                latitude: 29.751301,
                longitude: -95.391690
            }
        ];

        constructor(private $http, private $location, private $routeParams, private $scope) {

            this.$location = $location;

        }

    }


    angular.module('FoodTruckApp').controller('GoogleMapController', GoogleMapController);

}