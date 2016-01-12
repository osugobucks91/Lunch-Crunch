namespace FoodTruckApp.Controllers {

    import FoodTruck = FoodTruckApp.Models.FoodTruck;

    import Marker = google.maps.Marker;

    export class MapController {

        public foodTrucks: FoodTruck[];

        public marker: Marker;

        public center = { latitude: 29.56, longitude: -95.387044 };
        public zoom = 13;
        public control = {};
        public refresh = {};

        public addresses = ['2220 Brazos St, Houston, TX 77002', '6355 Clara Rd, Houston, TX 77041', '1 Reliant Pkwy Houston, TX 77054', '1953 Montrose, TX 77019', '11308 W Broadway St, Pearland, TX 77584'];

        public window = {
            model: {},
            show: false,
            options:
            {
                pixelOffset: { width: -1, height: -20 }
            }
        }

        public markers = [
            {
                id: 1,

                options: {
                    title: 'BellyUp',
                    href: '#/description/1',
                    image: 'https://pbs.twimg.com/profile_images/553279030179266560/Rro9lltT.jpeg'
                },

                latitude: 29.556014,
                longitude: -95.386004
            },
            {
                id: 2,
                options: {
                    title: 'Dasman',
                    href: '#/description/2',
                    image: 'https://pbs.twimg.com/profile_images/542554549194477568/HmZ5TfG2.jpeg'
                },
                latitude: 29.750165,
                longitude: -95.377044
            },
            {
                id: 3,
                options: {
                    title: 'St. Johns Fire',
                    href: '#/description/3',
                    image: 'https://pbs.twimg.com/profile_images/1858669485/shrimp_small_no_flame.jpg'
                },
                latitude: 29.721724,
                longitude: -95.387036
            },
            {
                id: 4,
                options: {
                    title: "Bernie's Bus",
                    href: '#/description/4',
                    image: 'https://pbs.twimg.com/profile_images/476566999565205505/X0MHTITJ.jpeg'
                },
                latitude: 29.861023,
                longitude: -95.554351
            },
            {
                id: 5,
                options: {
                    title: 'Skratch Food Truck',
                    href: '#/description/5',
                    image: 'https://pbs.twimg.com/profile_images/378800000022249313/518ec66dab82e9af0b465a6560377ff2.png'
                },
                latitude: 29.685072,
                longitude: -95.411090
            },
            {
                id: 6,
                options: {
                    title: 'The Waffle Bus',
                    href: '#/description/6',
                    image: 'https://pbs.twimg.com/profile_images/458784719140691969/fzKPyE8W.jpeg'
                },

                latitude: 29.751301,
                longitude: -95.391690
            }
        ];

        constructor(private $http, private $location, private $routeParams, private $scope) {

            this.$location = $location;

            $http.get('/api/foodtrucks')
                .then((response) => {
                    this.foodTrucks = response.data;
                });
            this.$location = $location;
        }



        public searchBoxEvents = {
            places_changed: (searchBox) => {
                this.placeToMarker(searchBox, 0);
            }
        };

        public searchBox = { template: 'searchBox.template.html', events: this.searchBoxEvents, parentdiv: 'searchBoxParent' };

        public placeToMarker(searchBox, id) {

            var place = searchBox.getPlaces();
            if (!place || place == 'undefined' || place.length == 0) {
                return;
            }

            var marker = {
                id: id,
                place_id: place[0].place_id,
                name: place[0].name,
                address: place[0].formatted_address,
                latitude: place[0].geometry.location.lat(),
                longitude: place[0].geometry.location.lng(),
                latlng: place[0].geometry.location.lat() + ',' + place[0].geometry.location.lng()
            };

            this.$scope.map.control.refresh({ latitude: marker.latitude, longitude: marker.longitude });
        }

    }
        
    }
