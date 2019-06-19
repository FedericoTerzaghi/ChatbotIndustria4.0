var wainy = angular.module('wainy', ["ngRoute"]);
wainy.config(function ($routeProvider) {
    $routeProvider
        .when("/start", {
            templateUrl: "Home/start",
            controller: "startController"

        })
        .when("/chat", {
            templateUrl: "Home/wainy",
            controller: "wainyController"

        })
        .when("/splash"), {
        templateUrl: "Home/splash",
        controller:"splashController"
        }
});