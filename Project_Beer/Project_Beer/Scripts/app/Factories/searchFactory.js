beerApp.factory('searchFactory', ["$http",  function($http) {
    var apiUrl = window.baseUrl + "api/search" ;
    var dataFactory = {};
    dataFactory.queryBeer = function (query, handleSuccess, handleError) {
        var requestUrl = apiUrl + "?q=" + query;
        return $http({
            method: "get",
            url: requestUrl
        }).then(handleSuccess, handleError);
    }
    return dataFactory;
    }
]);
