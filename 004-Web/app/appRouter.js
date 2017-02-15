angular.module('appRouter', ['externalModule', 'userModule']).config(function($urlRouterProvider) {
  $urlRouterProvider.otherwise('/');
});
