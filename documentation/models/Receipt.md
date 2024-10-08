# Receipt

**Properties**

| Name                        | Type                          | Required | Description |
| :-------------------------- | :---------------------------- | :------- | :---------- |
| Contact                     | ReceiptContact                | ✅       |             |
| UniqueReceiptId             | string                        | ✅       |             |
| ReceiptNumber               | string                        | ✅       |             |
| CreatedDate                 | string                        | ✅       |             |
| StoreExternalId             | string                        | ✅       |             |
| Currency                    | string                        | ✅       |             |
| TotalGrossPrice             | double                        | ✅       |             |
| PaymentMethods              | List`<ReceiptPaymentMethod>`  | ✅       |             |
| Items                       | List`<ReceiptItem>`           | ✅       |             |
| ExchangeRateToGroupCurrency | double                        | ❌       |             |
| TaxDetails                  | List`<ReceiptTaxDetail>`      | ❌       |             |
| UsedBonusChecks             | List`<ReceiptUsedBonusCheck>` | ❌       |             |
| UsedPromotions              | List`<ReceiptUsedPromotion>`  | ❌       |             |
| ExtraData                   | List`<ReceiptExtraDataItem>`  | ❌       |             |

<!-- This file was generated by liblab | https://liblab.com/ -->
