appControllers.controller('beerController', [
    "$scope", "$location", "$filter", "beerFactory", function beerController($scope, $location, $filter, beerFactory) {
        beerFactory.getAll().then(function (result) {
            $scope.beers = result.data;
        });
    }
]);