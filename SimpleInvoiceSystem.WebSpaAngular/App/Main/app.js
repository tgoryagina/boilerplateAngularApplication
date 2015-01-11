(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function ($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('login', {
                    url: '/',
                    templateUrl: '/App/Main/views/login/login.cshtml'
                })
                .state('register', {
                    url: '/register',
                    templateUrl: '/App/Main/views/login/register.cshtml'
                })
                .state('tasklist', {
                    url: '/tasklist',
                    templateUrl: '/App/Main/views/task/list.cshtml',
                    menu: 'TaskList' //Matches to name of 'TaskList' menu in SimpleInvoiceSystemNavigationProvider
                })
                .state('newtask', {
                    url: '/newtask',
                    templateUrl: '/App/Main/views/task/new.cshtml',
                    menu: 'NewTask' //Matches to name of 'NewTask' menu in SimpleInvoiceSystemNavigationProvider
                })
                .state('newInvoice', {
                    url: '/newInvoice',
                    templateUrl: '/App/Main/views/invoice/new.cshtml',
                });
        }
    ]);
})();