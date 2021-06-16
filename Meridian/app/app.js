
var app = angular.module('app', ['ngMaterial', 'ngRoute', 'ngAnimate', 'ngCookies', 'ngSanitize', 'ngMessages', 'ngAnimate'])
    .constant('_', window._)
    .constant('GlobalSettings',
        {
            ApplicationName: applicationName,
            LoginURL: loginURL,
            ApplicationTokenName: 'ApplicationToken',
            DynamicRouting: true
        })
    .constant('applicationRoutes', []);



app.config(function ($routeProvider, $httpProvider, $locationProvider, GlobalSettings, $cookiesProvider) {
    $locationProvider.html5Mode(true);
    window.routeProvider = $routeProvider;
    $cookiesProvider.defaults.domain = domain;
});
