angular.module('userModule',[]).config(function ($stateProvider) {
  var userProfile = {
    name:'userProfile',
    url:'/profile',
    templateUrl:'app/User/view/profile.html'
  }
  $stateProvider.state(userProfile);
});
