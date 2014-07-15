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

        var formdata = {
            'Name' : $scope.name,
            'Password': $scope.password
        };

        if (isValid) {

            //AngularJS performs an OPTIONS HTTP request for a cross-origin resource

            $http.post( "http://localhost:18310/api/Accountability/RegisterUser/",
                {'Name': "NAme", "Surname" : "Surname"}
            )
                .success(function (data) {                    
                    alert("sucess");
                })
                .error(function () {
                    alert("error");
                });
        } 
    }    
}]);

userManagementCtrl.controller('default', ['$scope', function ($scope) {
    $scope.controller = "default"
}]);