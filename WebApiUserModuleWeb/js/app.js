'use strict';

/* User Management App */

var userManagement = angular.module("userManagement",
                                    [
                                        "ngRoute",
                                        "userManagementCtrl"
                                    ]);

userManagement.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider.when('/login', {
            templateUrl: 'views/login.html',
            controller: 'login'
        }).when('/register', {
            templateUrl: 'views/register.html'
        }).otherwise({
            templateUrl: 'views/default.html',
            controller: 'default'
        })
    }
]);