(function () {
    var app = angular.module('app', ['ngRoute']);

    app.controller('HomeController', function ($scope) {
        $scope.Message = "Yahooo! we have succesfully done our first part";
    });
})();