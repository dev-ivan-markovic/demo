appControllers.controller('beerController', [
    "$scope", "$location", "$filter", "beerFactory", function beerController($scope, $location, $filter, beerFactory) {
       $scope.beers = [];
        beerFactory.getPage(1).then(function(result) {
            $scope.beers = result.data.Data;
        });
    }
]);