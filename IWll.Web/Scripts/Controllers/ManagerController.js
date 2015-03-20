var ManagerController = function ($scope, $http) {
    $scope.models = {
        helloAngular: 'I work!'
    };

    $scope.managers;

    $scope.queryManager = function () {
        $http.get('http://localhost:64794/api/manage')
            .success(function (data, status, header, config) {
                $scope.managers = data;
            }).error(function (data, status, header, config) {
                throw new Error("Something went wrong...");
            });
    };
};

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
ManagerController.$inject = ['$scope', '$http'];