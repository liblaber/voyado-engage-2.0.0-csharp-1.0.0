# PromotionsService

A list of all methods in the `PromotionsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                                                   | Description                                                                                                                                         |
| :-------------------------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------- |
| [MultichannelPromotionsGetByIdAsync](#multichannelpromotionsgetbyidasync)                                 | Gets the multichannel promotion with the identifier which is set by Voyado                                                                          |
| [MultichannelPromotionsUpdateAsync](#multichannelpromotionsupdateasync)                                   | Updates an existing multichannel promotion. Only multichannel promotion in status 'Draft' can be updated.                                           |
| [MultichannelPromotionsDeleteByIdAsync](#multichannelpromotionsdeletebyidasync)                           | Only unassigned multichannel promotions can be deleted                                                                                              |
| [MultichannelPromotionsGetValidityByIdAsync](#multichannelpromotionsgetvaliditybyidasync)                 | Gets the multichannel promotion with the identifier which is an internal reference for Voyado                                                       |
| [MultichannelPromotionsUpdateValidityAsync](#multichannelpromotionsupdatevalidityasync)                   | Updates duration of an existing multichannel promotion. Only multichannel promotion in status 'Draft' can be updated.                               |
| [MultichannelPromotionsGetByExternalIdAsync](#multichannelpromotionsgetbyexternalidasync)                 | Gets the multichannel promotion with the identifier which is an external reference for Voyado                                                       |
| [MultichannelPromotionsCreateAsync](#multichannelpromotionscreateasync)                                   | Only creates multichannel promotion in status 'Draft'.                                                                                              |
| [MultichannelPromotionsDeleteByExternalIdAsync](#multichannelpromotionsdeletebyexternalidasync)           | Only unassigned multichannel promotions can be deleted                                                                                              |
| [MultichannelPromotionsGetByValidityExternalIdAsync](#multichannelpromotionsgetbyvalidityexternalidasync) | Gets the multichannel promotion validity with the identifier which is an external reference for Voyado                                              |
| [OfferPromotionsRedeemByPromotionIdAsync](#offerpromotionsredeembypromotionidasync)                       | Redeem a promotion (multichannel offer or mobile swipe) for a Contact using the internal promotion Id Redemption channel can be POS, ECOM or OTHER. |
| [OfferPromotionsReactivatePromotionCodeAsync](#offerpromotionsreactivatepromotioncodeasync)               | Reactivate a redeemed reward voucher                                                                                                                |

## MultichannelPromotionsGetByIdAsync

Gets the multichannel promotion with the identifier which is set by Voyado

- HTTP Method: `GET`
- Endpoint: `/api/v2/promotions/multichannels/{id}`

**Parameters**

| Name | Type   | Required | Description                      |
| :--- | :----- | :------- | :------------------------------- |
| id   | string | ✅       | Promotion identifier from Voyado |

**Return Type**

`MultichannelPromotionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Promotions.MultichannelPromotionsGetByIdAsync("id");

Console.WriteLine(response);
```

## MultichannelPromotionsUpdateAsync

Updates an existing multichannel promotion. Only multichannel promotion in status 'Draft' can be updated.

- HTTP Method: `PUT`
- Endpoint: `/api/v2/promotions/multichannels/{id}`

**Parameters**

| Name  | Type                       | Required | Description                              |
| :---- | :------------------------- | :------- | :--------------------------------------- |
| input | MultichannelPromotionModel | ✅       | The request body.                        |
| id    | string                     | ✅       | Voyado multichannel promotion identifier |

**Return Type**

`MultichannelPromotionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new MultichannelPromotionModel("00000000-0000-0000-0000-000000000000", "name");

var response = await client.Promotions.MultichannelPromotionsUpdateAsync(input, "id");

Console.WriteLine(response);
```

## MultichannelPromotionsDeleteByIdAsync

Only unassigned multichannel promotions can be deleted

- HTTP Method: `DELETE`
- Endpoint: `/api/v2/promotions/multichannels/{id}`

**Parameters**

| Name | Type   | Required | Description                                   |
| :--- | :----- | :------- | :-------------------------------------------- |
| id   | string | ✅       | Voyado identifier to a multichannel promotion |

**Return Type**

`StatusCodeResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Promotions.MultichannelPromotionsDeleteByIdAsync("id");

Console.WriteLine(response);
```

## MultichannelPromotionsGetValidityByIdAsync

Gets the multichannel promotion with the identifier which is an internal reference for Voyado

- HTTP Method: `GET`
- Endpoint: `/api/v2/promotions/multichannels/{id}/validity`

**Parameters**

| Name | Type   | Required | Description                 |
| :--- | :----- | :------- | :-------------------------- |
| id   | string | ✅       | Identifier inside of Voyado |

**Return Type**

`PromotionValidityModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Promotions.MultichannelPromotionsGetValidityByIdAsync("id");

Console.WriteLine(response);
```

## MultichannelPromotionsUpdateValidityAsync

Updates duration of an existing multichannel promotion. Only multichannel promotion in status 'Draft' can be updated.

- HTTP Method: `PUT`
- Endpoint: `/api/v2/promotions/multichannels/{id}/validity`

**Parameters**

| Name  | Type                   | Required | Description                              |
| :---- | :--------------------- | :------- | :--------------------------------------- |
| input | PromotionValidityModel | ✅       | The request body.                        |
| id    | string                 | ✅       | Voyado multichannel promotion identifier |

**Return Type**

`MultichannelPromotionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new PromotionValidityModel("startDate");

var response = await client.Promotions.MultichannelPromotionsUpdateValidityAsync(input, "id");

Console.WriteLine(response);
```

## MultichannelPromotionsGetByExternalIdAsync

Gets the multichannel promotion with the identifier which is an external reference for Voyado

- HTTP Method: `GET`
- Endpoint: `/api/v2/promotions/multichannels`

**Parameters**

| Name       | Type   | Required | Description                           |
| :--------- | :----- | :------- | :------------------------------------ |
| externalId | string | ✅       | External identifier outside of Voyado |

**Return Type**

`MultichannelPromotionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Promotions.MultichannelPromotionsGetByExternalIdAsync("externalId");

Console.WriteLine(response);
```

## MultichannelPromotionsCreateAsync

Only creates multichannel promotion in status 'Draft'.

- HTTP Method: `POST`
- Endpoint: `/api/v2/promotions/multichannels`

**Parameters**

| Name  | Type                           | Required | Description       |
| :---- | :----------------------------- | :------- | :---------------- |
| input | MultichannelBasePromotionModel | ✅       | The request body. |

**Return Type**

`MultichannelPromotionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new MultichannelBasePromotionModel("name");

var response = await client.Promotions.MultichannelPromotionsCreateAsync(input);

Console.WriteLine(response);
```

## MultichannelPromotionsDeleteByExternalIdAsync

Only unassigned multichannel promotions can be deleted

- HTTP Method: `DELETE`
- Endpoint: `/api/v2/promotions/multichannels`

**Parameters**

| Name       | Type   | Required | Description                                     |
| :--------- | :----- | :------- | :---------------------------------------------- |
| externalId | string | ✅       | External identifier to a multichannel promotion |

**Return Type**

`StatusCodeResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Promotions.MultichannelPromotionsDeleteByExternalIdAsync("externalId");

Console.WriteLine(response);
```

## MultichannelPromotionsGetByValidityExternalIdAsync

Gets the multichannel promotion validity with the identifier which is an external reference for Voyado

- HTTP Method: `GET`
- Endpoint: `/api/v2/promotions/multichannels/validity`

**Parameters**

| Name       | Type   | Required | Description                           |
| :--------- | :----- | :------- | :------------------------------------ |
| externalId | string | ✅       | External identifier outside of Voyado |

**Return Type**

`PromotionValidityModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Promotions.MultichannelPromotionsGetByValidityExternalIdAsync("externalId");

Console.WriteLine(response);
```

## OfferPromotionsRedeemByPromotionIdAsync

Redeem a promotion (multichannel offer or mobile swipe) for a Contact using the internal promotion Id Redemption channel can be POS, ECOM or OTHER.

- HTTP Method: `POST`
- Endpoint: `/api/v2/promotions/codes/{promotionId}/redeem`

**Parameters**

| Name        | Type            | Required | Description             |
| :---------- | :-------------- | :------- | :---------------------- |
| input       | RedeemBodyModel | ✅       | The request body.       |
| promotionId | string          | ✅       | The id of the promotion |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new RedeemBodyModel();

var response = await client.Promotions.OfferPromotionsRedeemByPromotionIdAsync(input, "promotionId");

Console.WriteLine(response);
```

## OfferPromotionsReactivatePromotionCodeAsync

Reactivate a redeemed reward voucher

- HTTP Method: `POST`
- Endpoint: `/api/v2/promotions/reward-vouchers/{id}/reactivate`

**Parameters**

| Name | Type   | Required | Description                  |
| :--- | :----- | :------- | :--------------------------- |
| id   | string | ✅       | The id of the reward voucher |

**Return Type**

`string`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Promotions.OfferPromotionsReactivatePromotionCodeAsync("id");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
