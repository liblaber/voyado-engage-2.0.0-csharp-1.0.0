# ContactsService

A list of all methods in the `ContactsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| :-------------------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [ContactsVCountAsync](#contactsvcountasync)                                                                                       | Get number of approved contacts. This is a cached value that will be updated with a set frequency (normally once every 20 min).                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [ContactsVGetContactByIdAsync](#contactsvgetcontactbyidasync)                                                                     | Get a single contact, using the unique identifier. The dynamic fields of the response object depend on the current instance configuration.                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [ContactsVUpdateContactPostAsync](#contactsvupdatecontactpostasync)                                                               | Update one or several fields of a single contact. Dont send an empty value unless you want it to be empty.                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [ContactsVDeleteWithHeaderParamAsync](#contactsvdeletewithheaderparamasync)                                                       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [ContactsVCountByContactTypeAsync](#contactsvcountbycontacttypeasync)                                                             | Get number of approved contacts of given type. This is a cached value that will be updated with a set frequency (normally once every 20 min).                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [ContactBulkGetBulkStatusAsync](#contactbulkgetbulkstatusasync)                                                                   |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [ContactsVGetContactByTypeAndKeyValueInUrlAsyncAsync](#contactsvgetcontactbytypeandkeyvalueinurlasyncasync)                       | ! Please be aware that this endpoint is currently usable with either the key value being provided through ! ! the path or a query param. Hence there being two of the same endpoints. ! ! We recommend that you use the query param version (the first) as it is the more versatile one of the two ! Get a single contact of a certain type, using a key value that corresponds to the current instance configuration. This can only be used for contact types with exactly ONE key. The dynamic fields of the response object depend on the current configuration. |
| [ProductRecommendationGetProductRecommendationsAsync](#productrecommendationgetproductrecommendationsasync)                       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [ContactRetailKpiGetPurchaseHistoryAsync](#contactretailkpigetpurchasehistoryasync)                                               | Following summary shows the purchase history for a single contact, over all time, 12 months and 24 months.                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [BackInStockSubscriptionGetByContactIdAsync](#backinstocksubscriptiongetbycontactidasync)                                         | Get back in stock subscriptions for a contact                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [ContactsVGetContactByExternalIdAsyncAsync](#contactsvgetcontactbyexternalidasyncasync)                                           | Get a single contact of a certain type, using the contact's external id. The dynamic fields of the response object depend on the current configuration.                                                                                                                                                                                                                                                                                                                                                                                                             |
| [ContactsVGetContactByTypeAndKeyValueAsyncAsync](#contactsvgetcontactbytypeandkeyvalueasyncasync)                                 | Get a single contact of a certain type, using a key value that corresponds to the current instance configuration. This can only be used for contact types with exactly ONE key. The dynamic fields of the response object depend on the current configuration.                                                                                                                                                                                                                                                                                                      |
| [ContactMessageGetLatestMessagesByContactIdAsync](#contactmessagegetlatestmessagesbycontactidasync)                               | Get the latest messages (max 500) a contact has received                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [TransactionsGetTransactionsByContactIdAsync](#transactionsgettransactionsbycontactidasync)                                       | Get all purchase transactions for a single contact with optional offset and number of transactions in response.                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [BonusPointTransactionsGetBonusPointTransactionsForContactAsync](#bonuspointtransactionsgetbonuspointtransactionsforcontactasync) |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [ContactsVGetChangedContactIdsAsync](#contactsvgetchangedcontactidsasync)                                                         |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [OfferPromotionsGetPromotionsForContactAsync](#offerpromotionsgetpromotionsforcontactasync)                                       | Get available promotions for a contact. To filter on redemptionChannelType add it as a query string ?redemptionChannelType=POS It can be POS, ECOM or OTHER                                                                                                                                                                                                                                                                                                                                                                                                         |
| [ContactOverviewGetContactIdAsyncAsync](#contactoverviewgetcontactidasyncasync)                                                   | Get the contactId for one (or several) contacts using either: - email - socialSecurityNumber - mobilePhone - customKey (the customKey must be configured by your supplier) - any - the any field can contain email, socialSecurityNumber, mobilePhone or the custom key (and are checked in that order)                                                                                                                                                                                                                                                             |
| [ContactsVCreateContactHeaderParamAsync](#contactsvcreatecontactheaderparamasync)                                                 | Create a new, approved contact. If the contacts key identifier (example: Email) already exists : returns the GUID of the first entry found.                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [ContactsVPromoteToMemberAsync](#contactsvpromotetomemberasync)                                                                   | Promote a contact to a member with one or several required fields.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [ContactBulkCreateContactsInBulkAsync](#contactbulkcreatecontactsinbulkasync)                                                     |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [ContactBulkUpdateContactsInBulkAsync](#contactbulkupdatecontactsinbulkasync)                                                     |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [ContactPreferencesAcceptsSmsAsync](#contactpreferencesacceptssmsasync)                                                           | Update the preference that indicates whether or not a contact accepts to be contacted via sms. This will also approve an unapproved contact. The primary way of updating a contact preference is through the update contacts endpoint.                                                                                                                                                                                                                                                                                                                              |
| [BonusPointTransactionsAdjustRewardPointsAsync](#bonuspointtransactionsadjustrewardpointsasync)                                   | Adds reward points to a contact.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [ContactPreferencesAcceptsEmailAsync](#contactpreferencesacceptsemailasync)                                                       | Update the preference that indicates whether or not a contact accepts to be contacted via email. This will also approve an unapproved contact. The primary way of updating a contact preference is through the update contacts endpoint.                                                                                                                                                                                                                                                                                                                            |
| [ContactPreferencesAcceptsPostalAsync](#contactpreferencesacceptspostalasync)                                                     | Update the preference that indicates whether or not a contact accepts to be contacted via regular mail. This will also approve an unapproved contact. The primary way of updating a contact preference is through the update contacts endpoint.                                                                                                                                                                                                                                                                                                                     |
| [AssignPromotionAssignAsync](#assignpromotionassignasync)                                                                         | Assign a promotion (multichannel offer only) to a Contact using the internal Contact Id and the id of the promotion                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [OfferPromotionsRedeemAsync](#offerpromotionsredeemasync)                                                                         | Redeem a promotion (multichannel offer or mobile swipe) for a Contact using the internal Contact Id Redemption channel can be POS, ECOM or OTHER.                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [ContactMessageSmsUnsubscribeContactAsync](#contactmessagesmsunsubscribecontactasync)                                             | Optional messageId input if user wants to unsubscribe on specific message instead of last sent Sms                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [ContactMessageEmailUnsubscribeContactAsync](#contactmessageemailunsubscribecontactasync)                                         | Optional messageId input if user wants to unsubscribe on specific message instead of last sent email                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [ContactsVUpdateContactTypeAsync](#contactsvupdatecontacttypeasync)                                                               | Updates the contactType for a contact if all expected contact data is available                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |

## ContactsVCountAsync

Get number of approved contacts. This is a cached value that will be updated with a set frequency (normally once every 20 min).

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/count`

**Return Type**

`long`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVCountAsync();

Console.WriteLine(response);
```

## ContactsVGetContactByIdAsync

Get a single contact, using the unique identifier. The dynamic fields of the response object depend on the current instance configuration.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}`

**Parameters**

| Name      | Type   | Required | Description                |
| :-------- | :----- | :------- | :------------------------- |
| contactId | string | ✅       | Contact identifier (GUID). |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVGetContactByIdAsync("contactId");

Console.WriteLine(response);
```

## ContactsVUpdateContactPostAsync

Update one or several fields of a single contact. Dont send an empty value unless you want it to be empty.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}`

**Parameters**

| Name      | Type   | Required | Description                |
| :-------- | :----- | :------- | :------------------------- |
| input     | object | ✅       | The request body.          |
| contactId | string | ✅       | Contact identifier (GUID). |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVUpdateContactPostAsync(new object {}, "contactId");

Console.WriteLine(response);
```

## ContactsVDeleteWithHeaderParamAsync

- HTTP Method: `DELETE`
- Endpoint: `/api/v2/contacts/{contactId}`

**Parameters**

| Name      | Type   | Required | Description                                       |
| :-------- | :----- | :------- | :------------------------------------------------ |
| contactId | string | ✅       | Contact identifier (GUID).                        |
| source    | string | ❌       | Source system identifier (instance configuration) |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVDeleteWithHeaderParamAsync("contactId", "source");

Console.WriteLine(response);
```

## ContactsVCountByContactTypeAsync

Get number of approved contacts of given type. This is a cached value that will be updated with a set frequency (normally once every 20 min).

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactType}/count`

**Parameters**

| Name        | Type   | Required | Description                                     |
| :---------- | :----- | :------- | :---------------------------------------------- |
| contactType | string | ✅       | Id for contact type, e.g. "member" or "contact" |

**Return Type**

`long`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVCountByContactTypeAsync("contactType");

Console.WriteLine(response);
```

## ContactBulkGetBulkStatusAsync

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/bulk/status`

**Parameters**

| Name    | Type   | Required | Description                 |
| :------ | :----- | :------- | :-------------------------- |
| batchId | string | ✅       | Id from bulk contact import |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactBulkGetBulkStatusAsync("batchId");

Console.WriteLine(response);
```

## ContactsVGetContactByTypeAndKeyValueInUrlAsyncAsync

! Please be aware that this endpoint is currently usable with either the key value being provided through ! ! the path or a query param. Hence there being two of the same endpoints. ! ! We recommend that you use the query param version (the first) as it is the more versatile one of the two ! Get a single contact of a certain type, using a key value that corresponds to the current instance configuration. This can only be used for contact types with exactly ONE key. The dynamic fields of the response object depend on the current configuration.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactType}/bykey/{keyValue}`

**Parameters**

| Name        | Type   | Required | Description                            |
| :---------- | :----- | :------- | :------------------------------------- |
| contactType | string | ✅       | Contact type, e.g. "member".           |
| keyValue    | string | ✅       | Key value, e.g. ssn, phone number etc. |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVGetContactByTypeAndKeyValueInUrlAsyncAsync("contactType", "keyValue");

Console.WriteLine(response);
```

## ProductRecommendationGetProductRecommendationsAsync

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/productrecommendations`

**Parameters**

| Name      | Type   | Required | Description                |
| :-------- | :----- | :------- | :------------------------- |
| contactId | string | ✅       | Contact identifier (GUID). |

**Return Type**

`ProductRecommendationsModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ProductRecommendationGetProductRecommendationsAsync("contactId");

Console.WriteLine(response);
```

## ContactRetailKpiGetPurchaseHistoryAsync

Following summary shows the purchase history for a single contact, over all time, 12 months and 24 months.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/purchasehistorysummary`

**Parameters**

| Name      | Type   | Required | Description               |
| :-------- | :----- | :------- | :------------------------ |
| contactId | string | ✅       | Contact identifier (GUID) |

**Return Type**

`PurchaseHistorySummary`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactRetailKpiGetPurchaseHistoryAsync("contactId");

Console.WriteLine(response);
```

## BackInStockSubscriptionGetByContactIdAsync

Get back in stock subscriptions for a contact

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/backinstock/subscriptions`

**Parameters**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| contactId | string | ✅       |             |

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

await client.Contacts.BackInStockSubscriptionGetByContactIdAsync("contactId");
```

## ContactsVGetContactByExternalIdAsyncAsync

Get a single contact of a certain type, using the contact's external id. The dynamic fields of the response object depend on the current configuration.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactType}/byexternalid/{externalId}`

**Parameters**

| Name        | Type   | Required | Description                           |
| :---------- | :----- | :------- | :------------------------------------ |
| contactType | string | ✅       | Contact type, e.g. Member or Contact. |
| externalId  | string | ✅       | External contact id.                  |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVGetContactByExternalIdAsyncAsync("contactType", "externalId");

Console.WriteLine(response);
```

## ContactsVGetContactByTypeAndKeyValueAsyncAsync

Get a single contact of a certain type, using a key value that corresponds to the current instance configuration. This can only be used for contact types with exactly ONE key. The dynamic fields of the response object depend on the current configuration.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactType}/bykey`

**Parameters**

| Name        | Type   | Required | Description                            |
| :---------- | :----- | :------- | :------------------------------------- |
| contactType | string | ✅       | Contact type, e.g. "member".           |
| keyValue    | string | ✅       | Key value, e.g. ssn, phone number etc. |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVGetContactByTypeAndKeyValueAsyncAsync("contactType", "keyValue");

Console.WriteLine(response);
```

## ContactMessageGetLatestMessagesByContactIdAsync

Get the latest messages (max 500) a contact has received

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/messages/latest`

**Parameters**

| Name      | Type   | Required | Description                                                     |
| :-------- | :----- | :------- | :-------------------------------------------------------------- |
| contactId | string | ✅       | Contact identifier (GUID).                                      |
| count     | long   | ❌       | Max number of items to take. (Default value 100, Max value 500) |

**Return Type**

`ListResultOfApiMessage`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactMessageGetLatestMessagesByContactIdAsync("contactId", 6);

Console.WriteLine(response);
```

## TransactionsGetTransactionsByContactIdAsync

Get all purchase transactions for a single contact with optional offset and number of transactions in response.

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/transactions`

**Parameters**

| Name      | Type   | Required | Description                                      |
| :-------- | :----- | :------- | :----------------------------------------------- |
| contactId | string | ✅       | Contact identifier (GUID)                        |
| offset    | long   | ❌       | Number of items to skip. (Default value 0)       |
| count     | long   | ❌       | Max number of items to take. (Default value 100) |

**Return Type**

`PagedResultOfTransactionItem`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.TransactionsGetTransactionsByContactIdAsync("contactId", 1, 4);

Console.WriteLine(response);
```

## BonusPointTransactionsGetBonusPointTransactionsForContactAsync

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/bonuspointtransactions`

**Parameters**

| Name      | Type   | Required | Description                                              |
| :-------- | :----- | :------- | :------------------------------------------------------- |
| contactId | string | ✅       | The contact identifier (GUID).                           |
| offset    | long   | ❌       | The first item to retrieve. (Default value 0)            |
| count     | long   | ❌       | The max number of items to retrieve. (Default value 100) |

**Return Type**

`PagedResultOfBonusPointTransactionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.BonusPointTransactionsGetBonusPointTransactionsForContactAsync("contactId", 3, 3);

Console.WriteLine(response);
```

## ContactsVGetChangedContactIdsAsync

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/changes`

**Parameters**

| Name       | Type       | Required | Description                                         |
| :--------- | :--------- | :------- | :-------------------------------------------------- |
| changeType | ChangeType | ✅       | Created, Updated or Deleted                         |
| fromDate   | string     | ✅       | Start of timespan (ex 2023-05-04 11:20:00.000)      |
| toDate     | string     | ❌       | End of timespan (Default the current time and date) |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVGetChangedContactIdsAsync(ChangeType.Created, "fromDate", "toDate");

Console.WriteLine(response);
```

## OfferPromotionsGetPromotionsForContactAsync

Get available promotions for a contact. To filter on redemptionChannelType add it as a query string ?redemptionChannelType=POS It can be POS, ECOM or OTHER

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/{contactId}/promotions`

**Parameters**

| Name                  | Type   | Required | Description                                                  |
| :-------------------- | :----- | :------- | :----------------------------------------------------------- |
| contactId             | string | ✅       | Contact identifier                                           |
| redemptionChannelType | string | ❌       | Filter on redemptionChannelType it can be POS, ECOM or OTHER |

**Return Type**

`List<ApiPromotionModel>`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.OfferPromotionsGetPromotionsForContactAsync("contactId", "redemptionChannelType");

Console.WriteLine(response);
```

## ContactOverviewGetContactIdAsyncAsync

Get the contactId for one (or several) contacts using either: - email - socialSecurityNumber - mobilePhone - customKey (the customKey must be configured by your supplier) - any - the any field can contain email, socialSecurityNumber, mobilePhone or the custom key (and are checked in that order)

- HTTP Method: `GET`
- Endpoint: `/api/v2/contacts/id`

**Parameters**

| Name                 | Type   | Required | Description |
| :------------------- | :----- | :------- | :---------- |
| contactType          | string | ❌       |             |
| email                | string | ❌       |             |
| socialSecurityNumber | string | ❌       |             |
| mobilePhone          | string | ❌       |             |
| customKey            | string | ❌       |             |
| any                  | string | ❌       |             |

**Return Type**

`string`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactOverviewGetContactIdAsyncAsync("contactType", "email", "socialSecurityNumber", "mobilePhone", "customKey", "any");

Console.WriteLine(response);
```

## ContactsVCreateContactHeaderParamAsync

Create a new, approved contact. If the contacts key identifier (example: Email) already exists : returns the GUID of the first entry found.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts`

**Parameters**

| Name               | Type   | Required | Description                                                                                                                  |
| :----------------- | :----- | :------- | :--------------------------------------------------------------------------------------------------------------------------- |
| input              | object | ✅       | The request body.                                                                                                            |
| source             | string | ❌       | Source system identifier (instance configuration)                                                                            |
| storeExternalId    | string | ❌       | The unique id code of the current store (and therefore also the recruited-by store). Not mandatory but strongly recommended. |
| createAsUnapproved | string | ❌       | Contact is not approved on creation. (Default value false)                                                                   |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVCreateContactHeaderParamAsync(new object {}, "source", "storeExternalId", "createAsUnapproved");

Console.WriteLine(response);
```

## ContactsVPromoteToMemberAsync

Promote a contact to a member with one or several required fields.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/promoteToMember`

**Parameters**

| Name      | Type   | Required | Description                                       |
| :-------- | :----- | :------- | :------------------------------------------------ |
| input     | object | ✅       | The request body.                                 |
| contactId | string | ✅       | Contact identifier (GUID).                        |
| source    | string | ❌       | Source system identifier (instance configuration) |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactsVPromoteToMemberAsync(new object {}, "contactId", "source");

Console.WriteLine(response);
```

## ContactBulkCreateContactsInBulkAsync

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/bulk`

**Parameters**

| Name        | Type   | Required | Description                                               |
| :---------- | :----- | :------- | :-------------------------------------------------------- |
| input       | object | ✅       | The request body.                                         |
| contactType | string | ❌       | Optional, if not set the default ContactType will be used |

**Return Type**

`string`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactBulkCreateContactsInBulkAsync(new object {}, "contactType");

Console.WriteLine(response);
```

## ContactBulkUpdateContactsInBulkAsync

- HTTP Method: `PATCH`
- Endpoint: `/api/v2/contacts/bulk`

**Parameters**

| Name                  | Type   | Required | Description                                               |
| :-------------------- | :----- | :------- | :-------------------------------------------------------- |
| input                 | object | ✅       | The request body.                                         |
| contactType           | string | ❌       | Optional, if not set the default ContactType will be used |
| avoidTriggeringExport | bool   | ❌       | Optional, default value is false                          |

**Return Type**

`string`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactBulkUpdateContactsInBulkAsync(new object {}, "contactType", false);

Console.WriteLine(response);
```

## ContactPreferencesAcceptsSmsAsync

Update the preference that indicates whether or not a contact accepts to be contacted via sms. This will also approve an unapproved contact. The primary way of updating a contact preference is through the update contacts endpoint.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/preferences/acceptsSms`

**Parameters**

| Name      | Type        | Required | Description                |
| :-------- | :---------- | :------- | :------------------------- |
| input     | BoolRequest | ✅       | The request body.          |
| contactId | string      | ✅       | Contact identifier (GUID). |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new BoolRequest();

var response = await client.Contacts.ContactPreferencesAcceptsSmsAsync(input, "contactId");

Console.WriteLine(response);
```

## BonusPointTransactionsAdjustRewardPointsAsync

Adds reward points to a contact.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/rewardpointtransaction`

**Parameters**

| Name      | Type                  | Required | Description                |
| :-------- | :-------------------- | :------- | :------------------------- |
| input     | ApiAdjustRewardPoints | ✅       | The request body.          |
| contactId | string                | ✅       | Contact identifier (GUID). |

**Return Type**

`ApiAdjustRewardPointsResponse`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new ApiAdjustRewardPoints(1.86);

var response = await client.Contacts.BonusPointTransactionsAdjustRewardPointsAsync(input, "contactId");

Console.WriteLine(response);
```

## ContactPreferencesAcceptsEmailAsync

Update the preference that indicates whether or not a contact accepts to be contacted via email. This will also approve an unapproved contact. The primary way of updating a contact preference is through the update contacts endpoint.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/preferences/acceptsEmail`

**Parameters**

| Name      | Type        | Required | Description                |
| :-------- | :---------- | :------- | :------------------------- |
| input     | BoolRequest | ✅       | The request body.          |
| contactId | string      | ✅       | Contact identifier (GUID). |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new BoolRequest();

var response = await client.Contacts.ContactPreferencesAcceptsEmailAsync(input, "contactId");

Console.WriteLine(response);
```

## ContactPreferencesAcceptsPostalAsync

Update the preference that indicates whether or not a contact accepts to be contacted via regular mail. This will also approve an unapproved contact. The primary way of updating a contact preference is through the update contacts endpoint.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/preferences/acceptsPostal`

**Parameters**

| Name      | Type        | Required | Description                |
| :-------- | :---------- | :------- | :------------------------- |
| input     | BoolRequest | ✅       | The request body.          |
| contactId | string      | ✅       | Contact identifier (GUID). |

**Return Type**

`IApiContact`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new BoolRequest();

var response = await client.Contacts.ContactPreferencesAcceptsPostalAsync(input, "contactId");

Console.WriteLine(response);
```

## AssignPromotionAssignAsync

Assign a promotion (multichannel offer only) to a Contact using the internal Contact Id and the id of the promotion

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/promotions/{promotionId}/assign`

**Parameters**

| Name        | Type   | Required | Description             |
| :---------- | :----- | :------- | :---------------------- |
| contactId   | string | ✅       | Contact identifier      |
| promotionId | string | ✅       | The id of the promotion |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.AssignPromotionAssignAsync("contactId", "promotionId");

Console.WriteLine(response);
```

## OfferPromotionsRedeemAsync

Redeem a promotion (multichannel offer or mobile swipe) for a Contact using the internal Contact Id Redemption channel can be POS, ECOM or OTHER.

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/promotions/{promotionId}/redeem`

**Parameters**

| Name        | Type            | Required | Description             |
| :---------- | :-------------- | :------- | :---------------------- |
| input       | RedeemBodyModel | ✅       | The request body.       |
| contactId   | string          | ✅       | Contact identifier      |
| promotionId | string          | ✅       | The id of the promotion |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var input = new RedeemBodyModel();

var response = await client.Contacts.OfferPromotionsRedeemAsync(input, "contactId", "promotionId");

Console.WriteLine(response);
```

## ContactMessageSmsUnsubscribeContactAsync

Optional messageId input if user wants to unsubscribe on specific message instead of last sent Sms

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/unsubscribeSms`

**Parameters**

| Name      | Type   | Required | Description                |
| :-------- | :----- | :------- | :------------------------- |
| contactId | string | ✅       | Contact identifier (GUID). |
| messageId | string | ❌       | Message Id (string).       |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Contacts.ContactMessageSmsUnsubscribeContactAsync("contactId", "messageId");

Console.WriteLine(response);
```

## ContactMessageEmailUnsubscribeContactAsync

Optional messageId input if user wants to unsubscribe on specific message instead of last sent email

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/unsubscribeEmail`

**Parameters**

| Name      | Type   | Required | Description                |
| :-------- | :----- | :------- | :------------------------- |
| contactId | string | ✅       | Contact identifier (GUID). |
| messageId | string | ❌       | Message Id (string).       |

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

await client.Contacts.ContactMessageEmailUnsubscribeContactAsync("contactId", "messageId");
```

## ContactsVUpdateContactTypeAsync

Updates the contactType for a contact if all expected contact data is available

- HTTP Method: `POST`
- Endpoint: `/api/v2/contacts/{contactId}/updateContactType`

**Parameters**

| Name          | Type   | Required | Description                  |
| :------------ | :----- | :------- | :--------------------------- |
| contactId     | string | ✅       | Contact identifier (GUID).   |
| contactTypeId | string | ✅       | The ContactType id (string). |

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

await client.Contacts.ContactsVUpdateContactTypeAsync("contactId", "contactTypeId");
```

<!-- This file was generated by liblab | https://liblab.com/ -->
