angular.module("app").directive("cApp", function () {
    return {
        restrict: 'E',
        templateUrl: "app/components/cApp/cApp.template.html",
        controller: "cApp.controller",
        controllerAs: '$ctrl',
        transclude: true
    };
});