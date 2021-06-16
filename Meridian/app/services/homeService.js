angular.module("app").factory("homeService", function ($http) {

    var homeService = function () { }

    homeService.prototype.getContactDetails = function () {
        var promise = $http(
            {
                method: "POST",
                url: "/Home/GetContactDetails",
                contentType: "application/json"
            });
        return promise;
    };

    homeService.prototype.getBanner = function () {
        var promise = $http(
            {
                method: "POST",
                url: "/Home/GetBanner",
                contentType: "application/json"
            });
        return promise;
    };

    homeService.prototype.getHangBanners = function () {
        var promise = $http(
            {
                method: "POST",
                url: "/Home/GetHangBanners",
                contentType: "application/json"
            });
        return promise;
    };

    return new homeService;

});