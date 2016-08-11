mainModule.factory('dashboardService', function ($http, viewModelHelper) {
    var factory = {};

    factory.getBaseData = function (onReady, onError) {
        console.log("Get Base Data()");
        var getUrl = MyApp.rootPath + "api/DashboardApi";
        $http
            .get(getUrl)
            .success(onReady)
            .error(onError);
    }
    return factory;
});
