'use strict';

/* Controllers */

var userManagementCtrl = angular.module('userManagementCtrl', []);

userManagementCtrl.controller('login', ['$scope', '$http', function ($scope, $http) {
    $scope.submitForm = function (isValid) {
        $scope.submitted = true;
        if (isValid) {           
            $http({
                method: "POST",
                url: "http://localhost:18310/Token",
                data: "grant_type=password&username=" + $scope.name + "&password=" + $scope.password,
                headers: { "Content-Type": "application/x-www-form-urlencoded" }
            }).success(function (data) {
                alert("sucess");
            }).error(function () {
                alert("error");
            });            
        }
    }
}]);

userManagementCtrl.controller('register', ['$scope', '$http', function ($scope, $http) {   
    $scope.submitForm = function (isValid) {
        $scope.submitted = true;

        var formdata = {
            'Name' : $scope.name,
            'Password': $scope.password
        };

        if (isValid) {            
            $http.post( "http://localhost:18310/api/Accountability/RegisterUser/",
                formdata
            ).success(function (data) {                    
                alert("sucess");
            }).error(function () {
                alert("error");
            });
        } 
    }    
}]);

userManagementCtrl.controller('default', ['$scope', function ($scope) {
    $scope.controller = "default"
}]);