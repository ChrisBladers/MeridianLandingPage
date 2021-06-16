angular.module("app").controller("view.home.controller", function ($scope, homeService, $q) {
    var self = this;

    self.$onInit = function () {
        self.viewTitle = "Meridian Landing Home Page";
        self.contactDetails = null;
        self.banner = null;
        self.hangBanners = null;
        self.loadData();
    };

    self.loadData = function () {
        var promises = [
            self.getBanner(),
            self.getHangBanners(),
            self.getContactDetails()
        ];

        return $q.all(promises);
    }

    self.getContactDetails = function () {
        return homeService.getContactDetails().then(function (response) {
            if (response.data.Success === true) {
                self.contactDetails = response.data.Data;
            }
        });
    };

    self.getBanner = function () {
        return homeService.getBanner().then(function (response) {
            if (response.data.Success === true) {
                self.banner = response.data.Data;
            }
        });
    };

    self.getHangBanners = function () {
        return homeService.getHangBanners().then(function (response) {
            if (response.data.Success === true) {
                self.hangBanners = response.data.Data;
            }
        });
    };
});