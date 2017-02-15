angular.module('appRouter', ['externalModule']).config(function($urlRouterProvider) {
  $urlRouterProvider.otherwise('/');
});
