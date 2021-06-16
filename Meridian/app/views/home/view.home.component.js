angular.module("app").component("viewHome", {
        templateUrl: "/app/views/home/view.home.template.html",
    controller: "view.home.controller",
    require: {
        cApp: "^cApp"
    }
    });