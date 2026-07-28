window.angular.module('prismApp').component('custDcsPricingMatrix', {
    templateUrl: 'plugins/ppitextensions/custDcsPricingMatrix.htm',
    bindings: {
        close:   '<',
        dismiss: '<'
    },
    controller: ['$http', 'prismSessionInfo', function ($http, psInfo) {
        var $ctrl = this;

        $ctrl.loading   = true;
        $ctrl.saving    = false;
        $ctrl.loadError = null;
        $ctrl.saveError = null;
        $ctrl.levels    = [];
        $ctrl.dcs       = [];
        $ctrl.discounts = {};  // discounts[dcsSid][level] = decimal

        var apiBase = (function () {
            var svrUrl = new URL(psInfo.get().serveraddress);
            return svrUrl.protocol + '//' + svrUrl.hostname + '/ppExtApi';
        }());

        $ctrl.$onInit = function () {
            $http.get(apiBase + '/CustomerDcsPricing/matrix')
                .then(function (resp) {
                    var matrix = resp.data;
                    $ctrl.levels = matrix.levels || [];
                    $ctrl.dcs    = matrix.dcs    || [];

                    // Build lookup map, defaulting every cell to 0.
                    $ctrl.dcs.forEach(function (dcs) {
                        $ctrl.discounts[dcs.dcsSid] = {};
                        $ctrl.levels.forEach(function (level) {
                            $ctrl.discounts[dcs.dcsSid][level] = 0;
                        });
                    });
                    (matrix.discounts || []).forEach(function (rec) {
                        if ($ctrl.discounts[rec.dcsSid])
                            $ctrl.discounts[rec.dcsSid][rec.level] = rec.discount;
                    });
                })
                .catch(function () {
                    $ctrl.loadError = 'Failed to load discount matrix.';
                })
                .finally(function () {
                    $ctrl.loading = false;
                });
        };

        $ctrl.save = function () {
            $ctrl.saving    = true;
            $ctrl.saveError = null;

            var payload = [];
            $ctrl.dcs.forEach(function (dcs) {
                $ctrl.levels.forEach(function (level) {
                    payload.push({
                        dcsSid:   dcs.dcsSid,
                        level:    level,
                        discount: $ctrl.discounts[dcs.dcsSid][level] || 0
                    });
                });
            });

            $http.put(apiBase + '/CustomerDcsPricing/matrix', payload)
                .then(function () {
                    $ctrl.close();
                })
                .catch(function () {
                    $ctrl.saveError = 'Failed to save. Please try again.';
                })
                .finally(function () {
                    $ctrl.saving = false;
                });
        };
    }]
});
