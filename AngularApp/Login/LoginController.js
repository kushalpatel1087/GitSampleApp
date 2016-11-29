'use strict';

AngularApp.controller('LoginController', ['$scope','$location', 'Loginfactory', function ($scope,$location, Loginfactory) {
    $scope.dataloading = true;    
    $scope.login = function () {
        $scope.dataloading = false;
        Loginfactory.verifyUser($scope.username,$scope.pwd).then(function (data) {
            $scope.chkuser = data;
           
            if ($scope.chkuser == 'sucess') {
                // window.location.href = '/home';
                $location.path('/home');
            }
            else {
                alert('Invalid Credentails');
            }
            $scope.dataloading = true;
        })        
    }

}]);