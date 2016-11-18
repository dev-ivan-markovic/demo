beerApp.factory('beerFactory', ["$http",  function($http) {
    var apiUrl = window.baseApiUrl.replace("query","beers");
    var dataFactory = {};
    dataFactory.getAll = function (handleSuccess, handleError) {
        return $http({
            method: "get",
            url: apiUrl
        }).then(handleSuccess, handleError);
    }
    return dataFactory;
    }
]);
