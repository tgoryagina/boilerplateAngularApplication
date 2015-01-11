(function() {
    var app = angular.module('app');

    var controllerId = 'sts.views.login';

    app.controller(controllerId, [
        '$scope', '$http', '$q', '$location',
        function($scope, $http, $q, $location) {
            $scope.loginForm = {
                emailAddress: '',
                password: '',
                loginFailure: false
            };


            $scope.login = function() {

                var deferredObject = $q.defer();
                var result = $http.post(
                    '/Account/Login', {
                        Email: $scope.loginForm.emailAddress,
                        Password: $scope.loginForm.password,
                        RememberMe: false
                    }
                ).
                    success(function(data) {
                        if (data == "True") {
                            deferredObject.resolve({ success: true });
                        } else {
                            deferredObject.resolve({ success: false });
                        }
                    }).
                    error(function() {
                        deferredObject.resolve({ success: false });
                    });

                abp.ui.setBusy(
                    null,
                    result.then(function(result) {
                        if (result.success) {
                            $location.path('/newInvoice');
                        } else {
                            $scope.loginForm.loginFailure = true; //TODO: show in UI login error
                        }
                    })
                );

            };

            $scope.go = function() {
                $location.path('/newInvoice');
            };
        }
    ]);
})();

