angular.module("app").controller("cApp.controller", function ($rootScope, $route, $interval, $window, $location, $http, applicationRoutes, $q) {
    var self = this;

    self.$onInit = function () {
        self.viewTitle = "Meridian Landing Page";
        setRoutes();
    };

    var setRoutes = function () {
        routeProvider.when("/",
            {
                template: '<view-' + 'home' + '></view-' + 'home' + '>',
                reloadOnSearch: false,
                resolve: {
                    viewName: function () {
                        'Home'
                    }
                }
            });
        routeProvider.otherwise("/");
        $route.reload();
        //deferred.resolve();

    };

});



