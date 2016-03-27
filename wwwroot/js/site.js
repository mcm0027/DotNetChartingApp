

(function (angular) {
    'use strict';
    angular
        .module('myApp', [
            'ngAnimate',
            'ngTouch',
            'ui.bootstrap'
        ])
    //.config(['$routeProvider', function ($routeProvider) {
    //    $routeProvider.otherwise({ redirectTo: '/' });

    //}])
    .controller('mainController', [
        mainController])

    .factory('projectsService', [
        projectsService
    ]);

    function mainController() {

    }

})(window.angular);