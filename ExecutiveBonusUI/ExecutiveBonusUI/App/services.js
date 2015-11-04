angular.module('App')
    .service('PersonService', ['$http', function ($http) {
        this.getPerson = function () {
            return $http.get('/Person/');
        };

    }]);