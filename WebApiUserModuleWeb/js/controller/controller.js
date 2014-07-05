'use strict';

/* Controllers */

var userManagementCtrl = angular.module('userManagementCtrl', []);

userManagementCtrl.controller('login', ['$scope', function ($scope) {
    $scope.submitForm = function (isValid) {
        $scope.submitted = true;
        if (isValid) {
            alert("It is valid");
        }
    }
}]);

userManagementCtrl.controller('register', ['$scope', '$http', function ($scope, $http) {
    $scope.submitForm = function (isValid) {
        $scope.submitted = true;
        if (isValid) {
            alert("It is valid");
        } 
    }

    //$http.get('http://localhost:18310/api/Accountability/GetAllUser').success(function (data) {
    //    $scope.controller = data;
    //});

}]);

userManagementCtrl.controller('default', ['$scope', function ($scope) {
    $scope.controller = "default"
}]);