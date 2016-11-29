'use strict';

var LoginService = angular.module('LoginService', [])

LoginService.service('LoginMethod', function () {
    this.verifyUser = function () {
        alert('call service');
        return 'call';
    }
})

LoginService.factory('Loginfactory', ['$http', function ($http) {
    var Loginfactory = {};
    

    Loginfactory.verifyUser = function (username, pwd) {
        var url = 'http://localhost:56585/WebService/LoginREST.svc/ValidateUser/' + username +'/'+ pwd;

        return $http.get(url)
            .then(function (response) {                
                return response.data;
            },
          function (error) {
              return error;
          });
    }

    return Loginfactory;

    //return {
    //    verifyUser: function () {
    //        return $http.get(url);
    //    }
    //}

    //    return {

    //        verifyUser: function () {

    //            return $http({
    //                method: 'GET',
    //                headers: {
    //                    'Content-Type': 'application/json; charset=utf-8'
    //                },
    //                url: 'http://localhost:56585/WebService/LoginREST.svc/ValidateUser/admin/admin',
    //                data: {}
    //            });
    //        }   
    //}

}])

