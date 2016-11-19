appControllers.controller('beerController', [
    "$scope", "$location", "$filter", "beerFactory", "searchFactory", function beerController($scope, $location, $filter, beerFactory, searchFactory) {
       $scope.beers = [];
        //beerFactory.getPage(1).then(function(result) {
        //    $scope.beers = result.data.Data;
        //});

        $scope.showDetails = function(id) {            
            $scope.details = $filter('filter')($scope.beers, { Id: id })[0];         
        }
        $scope.onSearchBeer = function () {
            if ($scope.search.length < 4)
                return;
            searchFactory.queryBeer($scope.search).then(function(result) {
                    $scope.beers = result.data.Data;
           });
        }
    }
]);