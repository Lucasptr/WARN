angular.module('externalModule', [])
  .config(function ($stateProvider) {
    var principalExtArea = {
      name: 'principalExtArea',
      url: '/',
      templateUrl: 'app/ExternalArea/view/principal.html'
    };
    var loginExtArea = {
      name:'loginExtArea',
      url:'/login',
      templateUrl:'app/ExternalArea/view/login.html'
    }
    var registerExtArea = {
      name:'registerExtArea',
      url:'/register',
      templateUrl:'app/ExternalArea/view/register.html'
    }
    $stateProvider.state(principalExtArea);
    $stateProvider.state(loginExtArea);
    $stateProvider.state(registerExtArea);
  });
