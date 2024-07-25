# BonuschecksService

A list of all methods in the `BonuschecksService` service. Click on the method name to view detailed information about that method.

| Methods                                                                                               | Description                                                                                                                                                            |
| :---------------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [BonusChecksGetBonusChecksForContactAsync](#bonuschecksgetbonuschecksforcontactasync)                 | Get all bonus checks for a contact. Expired, redeemed and available. The result can be paginated, using the offset and count query parameters.                         |
| [BonusChecksGetRedeemedBonusChecksForContactAsync](#bonuschecksgetredeemedbonuschecksforcontactasync) | Get redeemed bonus checks for a contact. The result can be paginated, using the offset and count query parameters.                                                     |
| [BonusChecksGetAvailableBonusChecksAsync](#bonuschecksgetavailablebonuschecksasync)                   | Get available bonus checks for a contact. Expired and redeemed bonus checks are excluded The result can be paginated, using the _offset_ and _count_ query parameters. |
| [BonusChecksRedeemBonusCheckAsync](#bonuschecksredeembonuscheckasync)                                 | Redeem a bonus check for a certain contact.                                                                                                                            |

## BonusChecksGetBonusChecksForContactAsync

Get all bonus checks for a contact. Expired, redeemed and available. The result can be paginated, using the offset and count query parameters.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/bonuschecks`

**Parameters**

| Name      | Type   | Required | Description                                              |
| :-------- | :----- | :------- | :------------------------------------------------------- |
| contactId | string | ✅       | Contact identifier (GUID).                               |
| offset    | long   | ❌       | The first item to retrieve. (Default value 0)            |
| count     | long   | ❌       | The max number of items to retrieve. (Default value 100) |

**Return Type**

`PagedResultOfAllBonusCheckModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Bonuschecks.BonusChecksGetBonusChecksForContactAsync("contactId", 3, 6);

Console.WriteLine(response);
```

## BonusChecksGetRedeemedBonusChecksForContactAsync

Get redeemed bonus checks for a contact. The result can be paginated, using the offset and count query parameters.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/bonuschecks/redeemed`

**Parameters**

| Name      | Type   | Required | Description                                              |
| :-------- | :----- | :------- | :------------------------------------------------------- |
| contactId | string | ✅       | Contact identifier (GUID).                               |
| offset    | long   | ❌       | The first item to retrieve. (Default value 0)            |
| count     | long   | ❌       | The max number of items to retrieve. (Default value 100) |

**Return Type**

`PagedResultOfRedeemedBonusCheckModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Bonuschecks.BonusChecksGetRedeemedBonusChecksForContactAsync("contactId", 3, 8);

Console.WriteLine(response);
```

## BonusChecksGetAvailableBonusChecksAsync

Get available bonus checks for a contact. Expired and redeemed bonus checks are excluded The result can be paginated, using the _offset_ and _count_ query parameters.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/bonuschecks/available`

**Parameters**

| Name      | Type   | Required | Description                                      |
| :-------- | :----- | :------- | :----------------------------------------------- |
| contactId | string | ✅       | Contact identifier (GUID).                       |
| offset    | long   | ❌       | Number of items to skip. (Default value 0)       |
| count     | long   | ❌       | Max number of items to take. (Default value 100) |

**Return Type**

`PagedResultOfAvailableBonusCheckModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Bonuschecks.BonusChecksGetAvailableBonusChecksAsync("contactId", 5, 9);

Console.WriteLine(response);
```

## BonusChecksRedeemBonusCheckAsync

Redeem a bonus check for a certain contact.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/bonuschecks/{bonusCheckId}/redeem`

**Parameters**

| Name         | Type   | Required | Description                |
| :----------- | :----- | :------- | :------------------------- |
| contactId    | string | ✅       | Contact identifier (GUID). |
| bonusCheckId | string | ✅       | Bonus check identifier.    |

**Return Type**

`RedeemedBonusCheckModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Bonuschecks.BonusChecksRedeemBonusCheckAsync("contactId", "bonusCheckId");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
