var beerApp = angular.module('beerApp', ['ngRoute', 'app.controllers']);

beerApp.config([
    '$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', { controller: 'beerController', templateUrl: window.baseUrl + 'Home/Beer', caseInsensitiveMatch: true });
    }
]);
var appControllers = angular.module('app.controllers', []);