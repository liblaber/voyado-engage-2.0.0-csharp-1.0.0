# OrdersService

A list of all methods in the `OrdersService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| :---------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [OrdersRegisterOrderAsync](#ordersregisterorderasync) | The /orders endpoint is used to trigger automation flows in Engage and send out information about the order to your end customers. It could be used, for example, for an order confirmation, delivery confirmation or a return confirmation from an e-commerce system or store. The endpoint is called every time a change happens that you want to act on in Engage. All the data needed must be sent with every call, since this endpoint saves no data concerning orders. If you need to save data, use the /receipts endpoint instead. Note that there is no check against previous requests of the same order, thus two identical requests to this endpoint will trigger any matching automation twice. To accept an order: - The different orderStatus and paymentStatus values must be configured in Voyado. - totalGrossPrice, totalTax, item quantities etc. must be correct and add up. If the order is not accepted, a response with HTTP Status Code 400 or 422 and an error code will be returned. |

## OrdersRegisterOrderAsync

The /orders endpoint is used to trigger automation flows in Engage and send out information about the order to your end customers. It could be used, for example, for an order confirmation, delivery confirmation or a return confirmation from an e-commerce system or store. The endpoint is called every time a change happens that you want to act on in Engage. All the data needed must be sent with every call, since this endpoint saves no data concerning orders. If you need to save data, use the /receipts endpoint instead. Note that there is no check against previous requests of the same order, thus two identical requests to this endpoint will trigger any matching automation twice. To accept an order: - The different orderStatus and paymentStatus values must be configured in Voyado. - totalGrossPrice, totalTax, item quantities etc. must be correct and add up. If the order is not accepted, a response with HTTP Status Code 400 or 422 and an error code will be returned.

- HTTP Method: `POST`
- Endpoint: `/api/v2/orders`

**Parameters**

| Name  | Type  | Required | Description       |
| :---- | :---- | :------- | :---------------- |
| input | Order | ✅       | The request body. |

**Return Type**

`StatusCodeResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var contact = new OrderContact("matchKey", OrderContact.OrderContactMatchKeyType.Email);
var itemsItem = new OrderItem(OrderItem.OrderItemType.Purchase, "sku", 0.1, 3.23, "description");
var items = new List<OrderItem>() { itemsItem };
var input = new Order(contact, "orderNumber", "orderStatus", "paymentStatus", "createdDate", "storeId", "currency", 9.8, items);

var response = await client.Orders.OrdersRegisterOrderAsync(input);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
