var custDcsPricingConfigController = ['prismSessionInfo', '$rootScope',
function (psInfo, $rootScope) {

    var ps = psInfo.get();
    var perms = ps.permissions || {};
    $rootScope.discountLevelAccess = perms['pcpromoedit'] === 'ALLOW';

    ButtonHooksManager.addHandler(['before_navStoreOpsPriceManager'],
        function ($q, $uibModal, prismSessionInfo) {
            var d = $q.defer();

            var p = prismSessionInfo.get().permissions || {};
            if (p['pcpromoedit'] !== 'ALLOW') {
                d.reject();
                return d.promise;
            }

            var modalInstance = $uibModal.open({
                backdrop: 'static',
                keyboard: false,
                template: '<cust-dcs-pricing-matrix close="$ctrl.close" dismiss="$ctrl.dismiss"></cust-dcs-pricing-matrix>',
                controllerAs: '$ctrl',
                controller: function () {
                    var $ctrl = this;
                    $ctrl.close   = modalInstance.close;
                    $ctrl.dismiss = modalInstance.dismiss;
                }
            });

            // Always reject — no built-in action exists for this custom event name.
            d.reject();
            return d.promise;
        }
    );
}];

ConfigurationManager.addHandler(custDcsPricingConfigController);
