var custDcsPricingController = ['ModelEvent', 'prismSessionInfo', '$http', 'DocumentPersistedData',
function (ModelEvent, psInfo, $http, docData) {

    var handlerAfterItemInsert = function ($q, docItem) {
        var d = $q.defer();

        var custSid = docData.BillToCustomerData && docData.BillToCustomerData.Sid;
        if (!custSid || custSid.length === 0) {
            d.resolve();
            return d.promise;
        }

        var itemSid = docItem.invn_sbs_item_sid;
        if (!itemSid) {
            d.resolve();
            return d.promise;
        }

        var ps = psInfo.get();
        var svrUrl = new URL(ps.serveraddress);
        var apiBase = svrUrl.protocol + '//' + svrUrl.hostname + '/ppExtApi';

        $http.get(apiBase + '/CustomerDcsPricing/CustomerDiscount/' + custSid + '/' + itemSid)
            .then(function (resp) {
                var data = resp.data;
                if (data.Error || !data.discount || data.discount <= 0) {
                    d.resolve();
                    return;
                }

                // Don't override a discount that is already equal to or better than ours.
                // Prism may supply discount_perc, discount_amt, or both — derive whichever is missing.
                var price        = docItem.price         || 0;
                var existingPerc = docItem.discount_perc || 0;
                var existingAmt  = docItem.discount_amt  || 0;
                if (!existingPerc && existingAmt > 0 && price > 0)
                    existingPerc = (existingAmt / price) * 100;
                if (!existingAmt && existingPerc > 0 && price > 0)
                    existingAmt = price * (existingPerc / 100);
                if (existingPerc >= data.discount) {
                    d.resolve();
                    return;
                }

                var patchData = [{
                    'manual_disc_value': data.discount,
                    'manual_disc_type': 1,
                    'manual_disc_reason': 'DCS Level: ' + (data.level || '')
                }];

                $http.put(
                    '/v1/rest/document/' + docData.DocumentInformation.Sid +
                    '/item/' + docItem.sid +
                    '?filter=row_version,eq,' + docItem.row_version,
                    patchData
                )
                .then(function () { d.resolve(); })
                .catch(function (err) {
                    console.error('[custDcsPricing] Failed to apply discount:', err);
                    d.resolve();
                });
            })
            .catch(function (err) {
                console.error('[custDcsPricing] Discount lookup failed:', err);
                d.resolve();
            });

        return d.promise;
    };

    ModelEvent.addListener('item', 'onAfterInsert', handlerAfterItemInsert);
}];

ConfigurationManager.addHandler(custDcsPricingController);
