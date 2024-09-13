# TransactionsService

A list of all methods in the `TransactionsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                         | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| :------------------------------------------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [ImportTransactionsImportReceiptsAsync](#importtransactionsimportreceiptsasync) | The /receipts endpoint is used to store each customers purchase and returns in Engage. All fields in the data model can be used for segmentation and analysis in Engage. If you want to send out transactional emails, use the /orders endpoint instead. ### Identification To be able to store a receipt in Voyado, you need to connect it to a specific contact. In the example payload below the contact type is ÃƒÂ¢Ã¢â€šÂ¬Ã…â€œMemberÃƒÂ¢Ã¢â€šÂ¬Ã‚Â and the key type is ÃƒÂ¢Ã¢â€šÂ¬Ã…â€œemailÃƒÂ¢Ã¢â€šÂ¬Ã‚Â The key has to be a unique data field for the specific contact type, normally one of these fields: - contactId - email - mobilePhone - memberNumber - externalId - socialSecurityNumber (personal identity number - only Swedish or Finnish) |
| [ImportTransactionsImportAsync](#importtransactionsimportasync)                 | Required on **receipt**: externalId (Unique receipt id), invoiceNumber, customerKey, customerKeyType, invoiceCreatedDate, InvoiceModifiedDate, StoreName, StoreNumber Required on **transaction**: externalId (Unique transaction id), articleNr, quantity, price and type (RETURN/DISCOUNT/PURCHASE) Note! It's recommended to include Sku, as it's a required attribute when enriching purchase data from article data.                                                                                                                                                                                                                                                                                                                                     |

## ImportTransactionsImportReceiptsAsync

The /receipts endpoint is used to store each customers purchase and returns in Engage. All fields in the data model can be used for segmentation and analysis in Engage. If you want to send out transactional emails, use the /orders endpoint instead. ### Identification To be able to store a receipt in Voyado, you need to connect it to a specific contact. In the example payload below the contact type is ÃƒÂ¢Ã¢â€šÂ¬Ã…â€œMemberÃƒÂ¢Ã¢â€šÂ¬Ã‚Â and the key type is ÃƒÂ¢Ã¢â€šÂ¬Ã…â€œemailÃƒÂ¢Ã¢â€šÂ¬Ã‚Â The key has to be a unique data field for the specific contact type, normally one of these fields: - contactId - email - mobilePhone - memberNumber - externalId - socialSecurityNumber (personal identity number - only Swedish or Finnish)

- HTTP Method: `POST`
- Endpoint: `/api/v2/receipts`

**Parameters**

| Name  | Type    | Required | Description       |
| :---- | :------ | :------- | :---------------- |
| input | Receipt | ✅       | The request body. |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var contact = new ReceiptContact("matchKey", ReceiptContact.ReceiptContactMatchKeyType.Email);
var paymentMethodsItem = new ReceiptPaymentMethod("type", 5.08);
var paymentMethods = new List`<ReceiptPaymentMethod>`() { paymentMethodsItem };
var itemsItem = new ReceiptItem(ReceiptItem.ReceiptItemType.Purchase, "sku", 1, 1.17, 4.39, 1.12, "articleNumber", "articleName");
var items = new List`<ReceiptItem>`() { itemsItem };
var input = new Receipt(contact, "uniqueReceiptId", "receiptNumber", "createdDate", "storeExternalId", "currency", 7.19, paymentMethods, items);

var response = await client.Transactions.ImportTransactionsImportReceiptsAsync(input);

Console.WriteLine(response);
```

## ImportTransactionsImportAsync

Required on **receipt**: externalId (Unique receipt id), invoiceNumber, customerKey, customerKeyType, invoiceCreatedDate, InvoiceModifiedDate, StoreName, StoreNumber Required on **transaction**: externalId (Unique transaction id), articleNr, quantity, price and type (RETURN/DISCOUNT/PURCHASE) Note! It's recommended to include Sku, as it's a required attribute when enriching purchase data from article data.

- HTTP Method: `POST`
- Endpoint: `/api/v2/transactions`

**Parameters**

| Name  | Type                     | Required | Description       |
| :---- | :----------------------- | :------- | :---------------- |
| input | ImportTransactionsObject | ✅       | The request body. |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new ImportTransactionsObject();

var response = await client.Transactions.ImportTransactionsImportAsync(input);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
