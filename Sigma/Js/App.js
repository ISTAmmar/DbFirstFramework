var mainModule = angular.module('mainModule', []);

mainModule.factory('viewModelHelper', function ($http, $q, $window, $location) {
    var factory = {};

    factory.modelIsValid = true;
    factory.modelErrors = [];

    factory.resetModelErrors = function () {
        factory.modelErrors = [];
        factory.modelIsValid = true;
    }
    factory.apiGet = function (uri, data, success, failure, always) {
        factory.modelIsValid = true;
        $http.get(MyApp.rootPath + uri, data)
            .then(function (result) {
                success(result);
                if (always != null)
                    always();
            }, function (result) {
                if (failure != null) {
                    failure(result);
                }
                else {
                    var errorMessage = result.status + ':' + result.statusText;
                    if (result.data != null && result.data.Message != null)
                        errorMessage += ' - ' + result.data.Message;
                    factory.modelErrors = [errorMessage];
                    factory.modelIsValid = false;
                }
                if (always != null)
                    always();
            });
    }

    factory.apiPost = function (uri, data, success, failure, always) {
        factory.modelIsValid = true;
        $http.post(MyApp.rootPath + uri, data)
            .then(function (result) {
                success(result);
                if (always != null)
                    always();
            }, function (result) {
                if (failure != null) {
                    failure(result);
                }
                else {
                    var errorMessage = result.status + ':' + result.statusText;
                    if (result.data != null && result.data.Message != null)
                        errorMessage += ' - ' + result.data.Message;
                    factory.modelErrors = [errorMessage];
                    factory.modelIsValid = false;
                }
                if (always != null)
                    always();
            });
    }

    factory.goBack = function () {
        $window.history.back();
    }

    factory.navigateTo = function (path) {
        $location.path(MyApp.rootPath + path);
    }

    factory.refreshPage = function (path) {
        $window.location.href = MyApp.rootPath + path;
    }

    factory.clone = function (obj) {
        return JSON.parse(JSON.stringify(obj));
    }

    return factory;
});