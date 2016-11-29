'use strict';

AngularApp.controller('HomeController', ['$scope', '$http', 'Homefactory', function ($scope, $http, Homefactory) {
    $scope.$parent.showmenu = false;
    $scope.$parent.currentNavItem = 'HomePage';

    $scope.filltemplate = function () {
        
        Homefactory.fillTemplate().then(function (data) {
            $scope.templatelist = data;
            alert($scope.templatelist[1].TemplateName);
        });
    }

    $scope.filltemplate();

}]);