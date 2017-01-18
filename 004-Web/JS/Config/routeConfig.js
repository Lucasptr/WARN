angular.module("WarnClient").config(function($routeProvider) {
  $routeProvider.when("/login", {
    templateUrl: "view/login.html",
    controller: "loginCtrl"
  });
  $routeProvider.otherwise({redirectTo : '/login'})
});
