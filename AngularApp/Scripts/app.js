'use strict';
//angular.module('LoginService');

var AngularApp = angular.module('AngularApp', ['ng', 'ngRoute', 'ngAnimate', 'ngAria', 'ngMaterial', 'LoginService','HomeService'])

.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
    .when('/login', {
        templateUrl: 'Login/Login.html',
        controller: 'LoginController'
    })
    .when('/home', {
        templateUrl: 'Home/home.html',
        controller: 'HomeController'
    })
        .when('/admin', {
            templateUrl: 'Admin/admin.html',
            controller: 'AdminController'
        })
        .when('/contact', {
            templateUrl: 'Contact/contact.html',
            controller: 'ContactController'
        })
    .otherwise({ redirectTo: '/login' });
}]);

//AngularApp.controller('LoginController', function ($scope) {

//    $scope.login = function () {
//        alert('call');
//    }

//});