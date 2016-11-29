'use strict';

var HomeService = angular.module('HomeService', [])

HomeService.factory('Homefactory', ['$http', function ($http) {
    var Homefactory = {};

    
    Homefactory.fillTemplate = function () {
        var url = 'http://localhost:56585/WebService/HomeREST.svc/fillTemplate/';

        return $http.get(url)
            .then(function (response) {
                return response.data;
            },
          function (error) {
              return error;
          });
    }

    return Homefactory;    
}])