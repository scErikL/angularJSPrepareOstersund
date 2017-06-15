var app = angular.module("testApp", []);

app.controller("testController", ['$scope', '$http', function ($scope, $http) {

    $scope.data = "This will contain data";
    $scope.getData = getData;
    $scope.sendData = sendData;

    var person = {
        Name: "",
        Age: 0
    }

    $scope.person = person;

    function getData() {
        $http.get('/api/values/get')
        .then(function (response) {
            $scope.data = response.data;
        });
    }

    //"'We program Angular'"
    function sendData() {
        debugger;
        var object = JSON.stringify($scope.person);  //funkar
        $http.post('api/values/post', object)
        //$http.post('api/values/post', { 'Name': $scope.person.Name, 'Age': parseInt($scope.person.Age) })  //funkar oxå
        //$http.post('api/values/post', { 'Name': 'Erik', 'Age': 30 })  //funkar 
        .then(function (response) {
            var tmp = angular.copy($scope.person);
            $scope.data.push(tmp);
            $scope.person.Name = "";
            $scope.person.Age = 0;
            //alert("data sent");

        });

    }



}]);