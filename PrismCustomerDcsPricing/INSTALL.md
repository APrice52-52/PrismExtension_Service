# PrismCustomerDcsPricing — Installation Notes

Adds per-customer DCS discount levels to Retail Pro 9 Prism.
Customers are assigned a price level (stored in `customer.udf5_string`); a discount percentage is
configured per DCS × level combination and applied automatically when an item is added to a POS document.

---

## Prerequisites

- PrismExtensionServices host installed and running
- Apache reverse-proxying `/ppExtApi` to the PrismExtensionServices port (same host as the RP9 web server)
- MySQL user configured in PrismExtensionServices has read/write access to `rpsods`
- Customer price levels populated in `rpsods.customer.udf5_string`

---

## 1. Back-end — Plugin DLL

Copy the following files into the `plugins\` subfolder of the PrismExtensionServices installation:

```
PrismCustomerDcsPricing.dll
PrismCustomerDcsPricing.pdb        (optional — for stack traces)
```

> `PrismExtensionServices.Shared.dll` must **not** be copied — the host provides it.

Restart the **Prism Extension Service** after copying. On first start the plugin will:
- Create `rpsods.ppitcustdcspricing` if it does not exist
- Seed a default row (discount = 0) for every active DCS × customer level combination

---

## 2. Prism Web Client — JavaScript files

Copy the following files to the RP9 web server, preserving the relative paths shown:

| Source (`WebClient/`) | Destination (`C:\ProgramData\RetailPro\Server\WebClient\`) |
|-----------------------|------------------------------------------------------------|
| `plugins\ppitextensions\custDcsPricingPlugin.js` | `plugins\ppitextensions\custDcsPricingPlugin.js` |
| `plugins\ppitextensions\custDcsPricingConfig.js` | `plugins\ppitextensions\custDcsPricingConfig.js` |
| `plugins\ppitextensions\custDcsPricingMatrix.component.js` | `plugins\ppitextensions\custDcsPricingMatrix.component.js` |
| `plugins\ppitextensions\custDcsPricingMatrix.htm` | `plugins\ppitextensions\custDcsPricingMatrix.htm` |

---

## 3. Prism Web Client — View override

Copy the merchandise button layout override:

| Source (`WebClient/`) | Destination (`C:\ProgramData\RetailPro\Server\WebClient\`) |
|-----------------------|------------------------------------------------------------|
| `customizations\views\default\buttons-merchandise.htm` | `customizations\views\default\buttons-merchandise.htm` |

> If a `buttons-merchandise.htm` override already exists at the destination, merge the
> `<div class="col-xs-3">` block containing the `img-btn event-name="openCustDcsPricing"` button
> into the existing file rather than replacing it wholesale.

---

## 4. Prism Web Client — customizations.html

Add the following three `<script>` tags inside `customizations.html`
(`C:\ProgramData\RetailPro\Server\WebClient\customizations.html`):

```html
<script type="text/javascript" src="/plugins/ppitextensions/custDcsPricingPlugin.js"></script>
<script type="text/javascript" src="/plugins/ppitextensions/custDcsPricingMatrix.component.js"></script>
<script type="text/javascript" src="/plugins/ppitextensions/custDcsPricingConfig.js"></script>
```

> `custDcsPricingConfig.js` must load **after** `custDcsPricingMatrix.component.js`
> (the config registers the button hook that opens the modal component).

---

## 5. Permission — pcpromoedit

The **Discount Levels** button in store-ops is visible to all users but enabled only for employees
whose Prism session has `permissions['pcpromoedit'] === 'ALLOW'`.

Assign the `pcpromoedit` permission to the relevant employee groups in Retail Pro back-office.

---

## Verification

1. Open Prism → Store Operations → Merchandise.
2. **Without** `pcpromoedit`: the **Discount Levels** button is greyed out.
3. **With** `pcpromoedit`: the button is active — click it to open the discount matrix.
4. Edit a discount percentage and click **Save** — changes persist across sessions.
5. Add a customer with a configured price level to a POS transaction, then scan an item in
   their DCS — the discount is applied automatically on insert.
