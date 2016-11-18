beerApp.factory('beerFactory', ["$http",  function($http) {
    var apiUrl = window.baseUrl + "api/beer" ;
    var dataFactory = {};
    dataFactory.getPage = function (page, handleSuccess, handleError) {
        var requestUrl = apiUrl + "?currentPage=" + page;
        return $http({
            method: "get",
            url: requestUrl
        }).then(handleSuccess, handleError);
    }
    return dataFactory;
    }
]);
