(function() {
    var app = angular.module('app');

    var controllerId = 'sts.views.register';

    app.controller(controllerId, [
        '$scope', '$http', '$q', '$location',
        function($scope, $http, $q, $location) {
            $scope.registerForm = {
                emailAddress: '',
                password: '',
                confirmPassword: '',
                registrationFailure: false
            };

            $scope.register = function() {

                var deferredObject = $q.defer();
                var result = $http.post(
                    '/Account/Register', {
                        Email: $scope.registerForm.emailAddress,
                        Password: $scope.registerForm.password,
                        ConfirmPassword: $scope.registerFormconfirmPassword
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
                            $scope.registerForm.registrationFailure = true; //TODO: show in UI registration error
                        }
                    })
                );
            };
        }
    ]);
})();