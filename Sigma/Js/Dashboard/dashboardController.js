mainModule.controller("dashboardController", function ($scope, dashboardService, $http, $location) {
    var self = this;
    
    var initialize = function () {
        dashboardService.getBaseData(function (response) {
            $scope.distributors = response;
        },
        function (err) {
            
        });
    }

    $scope.showDistributor = function(dis) {
        alert("You selected = " + dis.DistributorName);
    }
    
    initialize();
});
