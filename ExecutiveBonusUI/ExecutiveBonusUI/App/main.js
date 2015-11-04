var App = angular.module('App', []);

App.controller('tableController', function ($scope, PersonService) {
    $scope.loading = true;
    $scope.addMode = false;

    $scope.showData = function () {

        $scope.curPage = 0;
        $scope.pageSize = 3;

        PersonService.getPerson().success(function (data) {
            $scope.persons = data;
        });

        $scope.numberOfPages = function () {

            return Math.ceil($scope.persons.length / $scope.pageSize);
        };
    }

    $scope.do_some_action = function (data) {
        var hash = 'You have selected  ' + data.FirstName;
        alert(hash);
    }
});


angular.module('App').filter('pagination', function () {
    return function (input, start) {
        start = +start;
        return input.slice(start);
    };
});
