# InventoryService

A list of all methods in the `InventoryService` service. Click on the method name to view detailed information about that method.

| Methods                                                                             | Description                                                                                                                                                                                                                                                                                                                                                               |
| :---------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [InventoryUpdateStockLevelAsync](#inventoryupdatestocklevelasync)                   | Update stock level for a specific SKU. Request model: - Sku*: Unique SKU of the product. E.g: "123XYZ" - Quantity*: The latest stock quantity of the product. E.g: 10 - Locale: Culture code. A corresponding product feed should be configured. E.g: "sv-se" - ExternalId: External identifier. E.g: "SE-123XYZ" \* required                                             |
| [InventoryUpdateStockLevelsAsync](#inventoryupdatestocklevelsasync)                 | Batch update of stock levels for multiple SKU's. Request model: - Sku*: Unique SKU of the product. E.g: "123XYZ" - Quantity*: The latest stock quantity of the product. E.g: 10 - Locale: Culture code. A corresponding product feed should be configured. E.g: "sv-se" - ExternalId: External identifier. E.g: "SE-123XYZ" \* required                                   |
| [BackInStockSubscriptionSubscribeAsync](#backinstocksubscriptionsubscribeasync)     | Create a back in stock subscription for a specific SKU. Request model: - ContactId*: Contact id of the subscriber. E.g: "FF9FD9AF-6778-4714-B0FE-F6E6612840C8" - Sku*: Unique SKU of the product. E.g: "123XYZ" - Locale\*: Culture code. A corresponding product feed should be configured. E.g: "sv-se" - ExternalId: External identifier. E.g: "SE-123XYZ" \* required |
| [BackInStockSubscriptionUnsubscribeAsync](#backinstocksubscriptionunsubscribeasync) | Delete a specific back in stock subscription.                                                                                                                                                                                                                                                                                                                             |

## InventoryUpdateStockLevelAsync

Update stock level for a specific SKU. Request model: - Sku*: Unique SKU of the product. E.g: "123XYZ" - Quantity*: The latest stock quantity of the product. E.g: 10 - Locale: Culture code. A corresponding product feed should be configured. E.g: "sv-se" - ExternalId: External identifier. E.g: "SE-123XYZ" \* required

- HTTP Method: `PUT`
- Endpoint: `/api/v2/inventory/stock-levels`

**Parameters**

| Name  | Type              | Required | Description       |
| :---- | :---------------- | :------- | :---------------- |
| input | StockLevelRequest | ✅       | The request body. |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new StockLevelRequest();

var response = await client.Inventory.InventoryUpdateStockLevelAsync(input);

Console.WriteLine(response);
```

## InventoryUpdateStockLevelsAsync

Batch update of stock levels for multiple SKU's. Request model: - Sku*: Unique SKU of the product. E.g: "123XYZ" - Quantity*: The latest stock quantity of the product. E.g: 10 - Locale: Culture code. A corresponding product feed should be configured. E.g: "sv-se" - ExternalId: External identifier. E.g: "SE-123XYZ" \* required

- HTTP Method: `PUT`
- Endpoint: `/api/v2/inventory/stock-levels/batch`

**Parameters**

| Name  | Type                      | Required | Description       |
| :---- | :------------------------ | :------- | :---------------- |
| input | List`<StockLevelRequest>` | ✅       | The request body. |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var inputItem = new StockLevelRequest();
var input = new List<StockLevelRequest>() { inputItem };

var response = await client.Inventory.InventoryUpdateStockLevelsAsync(input);

Console.WriteLine(response);
```

## BackInStockSubscriptionSubscribeAsync

Create a back in stock subscription for a specific SKU. Request model: - ContactId*: Contact id of the subscriber. E.g: "FF9FD9AF-6778-4714-B0FE-F6E6612840C8" - Sku*: Unique SKU of the product. E.g: "123XYZ" - Locale\*: Culture code. A corresponding product feed should be configured. E.g: "sv-se" - ExternalId: External identifier. E.g: "SE-123XYZ" \* required

- HTTP Method: `POST`
- Endpoint: `/api/v2/inventory/backinstock/subscriptions`

**Parameters**

| Name  | Type                | Required | Description       |
| :---- | :------------------ | :------- | :---------------- |
| input | SubscriptionRequest | ✅       | The request body. |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new SubscriptionRequest();

var response = await client.Inventory.BackInStockSubscriptionSubscribeAsync(input);

Console.WriteLine(response);
```

## BackInStockSubscriptionUnsubscribeAsync

Delete a specific back in stock subscription.

- HTTP Method: `DELETE`
- Endpoint: `/api/v2/inventory/backinstock/subscriptions/{subscriptionId}`

**Parameters**

| Name           | Type   | Required | Description |
| :------------- | :----- | :------- | :---------- |
| subscriptionId | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Inventory.BackInStockSubscriptionUnsubscribeAsync("subscriptionId");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
