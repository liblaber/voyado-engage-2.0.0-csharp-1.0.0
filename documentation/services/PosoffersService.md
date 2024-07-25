# PosoffersService

A list of all methods in the `PosoffersService` service. Click on the method name to view detailed information about that method.

| Methods                                                                                                         | Description                                                                                                                                                                                                                                                                         |
| :-------------------------------------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [PosOfferGetAllPosOffersByKeyAsync](#posoffergetallposoffersbykeyasync)                                         | Get all POS offers for a contact. Expired, redeemed and available. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.                    |
| [PosOfferGetAvailablePosOffersByKeyAsync](#posoffergetavailableposoffersbykeyasync)                             | Get all available POS offers for a contact. Expired and redeemed offers are excluded. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance. |
| [PosOfferGetAllPosOffersByContactTypeAndKeyAsync](#posoffergetallposoffersbycontacttypeandkeyasync)             | Get all POS offers for a contact. Expired, redeemed and available. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.                    |
| [PosOfferGetAvailablePosOffersByContactTypeAndKeyAsync](#posoffergetavailableposoffersbycontacttypeandkeyasync) | Get all available POS offers for a contact. Expired and redeemed offers are excluded. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance. |
| [PosOfferGetAllPosOffersForContactAsync](#posoffergetallposoffersforcontactasync)                               | Get all POS offers for a contact. Expired, redeemed and available. The result can be paginated, using the offset and count query parameters. Note: _expiresOn_ is obsolete and is always **null**                                                                                   |
| [PosOfferGetAvailablePosOffersForContactAsync](#posoffergetavailableposoffersforcontactasync)                   | Get all available POS offers for a contact. Expired and redeemed offers are excluded. The result can be paginated, using the offset and count query parameters.                                                                                                                     |
| [PosOfferRedeemAsync](#posofferredeemasync)                                                                     | Redeems a POS offer for a Contact using the internal Contact Id                                                                                                                                                                                                                     |
| [PosOfferRedeemByKeyAsync](#posofferredeembykeyasync)                                                           | Redeems a POS offer for a Contact using the key for the contact type Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.                  |
| [PosOfferRedeemByContactTypeAndKeyAsync](#posofferredeembycontacttypeandkeyasync)                               | Redeems a POS offer for a Contact using the key for the contact type Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.                  |

## PosOfferGetAllPosOffersByKeyAsync

Get all POS offers for a contact. Expired, redeemed and available. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/bykey/{keyValue}/posoffers/all`

**Parameters**

| Name     | Type   | Required | Description                                                      |
| :------- | :----- | :------- | :--------------------------------------------------------------- |
| keyValue | string | ✅       | Key value, e.g. ssn, externalId, memberNumber, phone number etc. |

**Return Type**

`PagedResultOfAllLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferGetAllPosOffersByKeyAsync("keyValue");

Console.WriteLine(response);
```

## PosOfferGetAvailablePosOffersByKeyAsync

Get all available POS offers for a contact. Expired and redeemed offers are excluded. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/bykey/{keyValue}/posoffers/available`

**Parameters**

| Name     | Type   | Required | Description                                                      |
| :------- | :----- | :------- | :--------------------------------------------------------------- |
| keyValue | string | ✅       | Key value, e.g. ssn, externalId, memberNumber, phone number etc. |

**Return Type**

`PagedResultOfAvailableLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferGetAvailablePosOffersByKeyAsync("keyValue");

Console.WriteLine(response);
```

## PosOfferGetAllPosOffersByContactTypeAndKeyAsync

Get all POS offers for a contact. Expired, redeemed and available. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactType}/bykey/{keyValue}/posoffers/all`

**Parameters**

| Name        | Type   | Required | Description                                                      |
| :---------- | :----- | :------- | :--------------------------------------------------------------- |
| keyValue    | string | ✅       | Key value, e.g. ssn, externalId, memberNumber, phone number etc. |
| contactType | string | ✅       | Contact type, e.g. "member".                                     |

**Return Type**

`PagedResultOfAllLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferGetAllPosOffersByContactTypeAndKeyAsync("keyValue", "contactType");

Console.WriteLine(response);
```

## PosOfferGetAvailablePosOffersByContactTypeAndKeyAsync

Get all available POS offers for a contact. Expired and redeemed offers are excluded. Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactType}/bykey/{keyValue}/posoffers/available`

**Parameters**

| Name        | Type   | Required | Description                                                      |
| :---------- | :----- | :------- | :--------------------------------------------------------------- |
| keyValue    | string | ✅       | Key value, e.g. ssn, externalId, memberNumber, phone number etc. |
| contactType | string | ✅       | Contact type, e.g. "member".                                     |

**Return Type**

`PagedResultOfAvailableLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferGetAvailablePosOffersByContactTypeAndKeyAsync("keyValue", "contactType");

Console.WriteLine(response);
```

## PosOfferGetAllPosOffersForContactAsync

Get all POS offers for a contact. Expired, redeemed and available. The result can be paginated, using the offset and count query parameters. Note: _expiresOn_ is obsolete and is always **null**

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/posoffers/all`

**Parameters**

| Name      | Type   | Required | Description                                              |
| :-------- | :----- | :------- | :------------------------------------------------------- |
| contactId | string | ✅       | Contact identifier (GUID).                               |
| offset    | long   | ❌       | The first item to retrieve. (Default value 0)            |
| count     | long   | ❌       | The max number of items to retrieve. (Default value 100) |

**Return Type**

`PagedResultOfAllLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferGetAllPosOffersForContactAsync("contactId", 2, 7);

Console.WriteLine(response);
```

## PosOfferGetAvailablePosOffersForContactAsync

Get all available POS offers for a contact. Expired and redeemed offers are excluded. The result can be paginated, using the offset and count query parameters.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/posoffers/available`

**Parameters**

| Name      | Type   | Required | Description                                              |
| :-------- | :----- | :------- | :------------------------------------------------------- |
| contactId | string | ✅       | Contact identifier (GUID).                               |
| offset    | long   | ❌       | The first item to retrieve. (Default value 0)            |
| count     | long   | ❌       | The max number of items to retrieve. (Default value 100) |

**Return Type**

`PagedResultOfAvailableLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferGetAvailablePosOffersForContactAsync("contactId", 3, 0);

Console.WriteLine(response);
```

## PosOfferRedeemAsync

Redeems a POS offer for a Contact using the internal Contact Id

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/posoffers/{id}/redeem`

**Parameters**

| Name      | Type   | Required | Description                                   |
| :-------- | :----- | :------- | :-------------------------------------------- |
| id        | string | ✅       | The id returned from the get operation (GUID) |
| contactId | string | ✅       | Contact identifier (GUID).                    |

**Return Type**

`RedeemedLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferRedeemAsync("id", "contactId");

Console.WriteLine(response);
```

## PosOfferRedeemByKeyAsync

Redeems a POS offer for a Contact using the key for the contact type Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/bykey/{keyValue}/posoffers/{id}/redeem`

**Parameters**

| Name     | Type   | Required | Description                                                      |
| :------- | :----- | :------- | :--------------------------------------------------------------- |
| id       | string | ✅       | The id returned from the get operation (GUID)                    |
| keyValue | string | ✅       | Key value, e.g. ssn, externalId, memberNumber, phone number etc. |

**Return Type**

`RedeemedLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferRedeemByKeyAsync("id", "keyValue");

Console.WriteLine(response);
```

## PosOfferRedeemByContactTypeAndKeyAsync

Redeems a POS offer for a Contact using the key for the contact type Finds the contact by using a key value other than Contact Id. This can only be used for contact types with exactly ONE key. The contact key attribute is configured for each Voyado instance.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactType}/bykey/{keyValue}/posoffers/{id}/redeem`

**Parameters**

| Name        | Type   | Required | Description                                                      |
| :---------- | :----- | :------- | :--------------------------------------------------------------- |
| id          | string | ✅       | The id returned from the get operation (GUID)                    |
| keyValue    | string | ✅       | Key value, e.g. ssn, externalId, memberNumber, phone number etc. |
| contactType | string | ✅       | Contact type, e.g. "member" or "contact".                        |

**Return Type**

`RedeemedLoyaltyBarClaimModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Posoffers.PosOfferRedeemByContactTypeAndKeyAsync("id", "keyValue", "contactType");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
