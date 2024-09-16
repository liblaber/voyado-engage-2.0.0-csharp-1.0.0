# PointAccountsService

A list of all methods in the `PointAccountsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                         | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| :------------------------------------------------------------------------------ | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [PointAccountPointAccountGetAsync](#pointaccountpointaccountgetasync)           | Get the point account by point account id                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [PointAccountPointDefinitionAsync](#pointaccountpointdefinitionasync)           | ## Gets a point account matched with the pointDefinitionId Gets the name, id and description for each pointDefinition                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [PointAccountPointTransactionsAsync](#pointaccountpointtransactionsasync)       |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [PointAccountPointDefinitionsAsync](#pointaccountpointdefinitionsasync)         | ## Gets point definitions                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [PointAccountPointAccountGet2Async](#pointaccountpointaccountget2async)         | Gets a list of accounts by contact id                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [PointAccountPointTransactions2Async](#pointaccountpointtransactions2async)     | There are two ways to fetch the list of transactions: - Using just the accountId returns the transactions for that particular points account. If this is used, the parameters contactId and definitionId are not required. If they are given, they will just be ignored. - The other way is to specify both contactId and definitionId. Both must be given. The optional parameters offset and count can be used in both cases to paginate the results. The optional parameter filter can also be used to fetch active points, pending points or both. All parameters are added to the query string.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [PointAccountAddPointTransactionsAsync](#pointaccountaddpointtransactionsasync) | ## Point transactions being sent to a contacts specified point account, the endpoint will able to take max 1000 transaction rows. ### The following fields should be provided and have certain rules: - contactId: Must be a Guid - amount: The amount of points, negative amounts are accepted. - definitionId: specifies to which point account each transaction should be sent to - timeStamp: If not provided then the default value is taken from the requestors system timezone. - source: Must be provided or else that specified transaction will not be accepted. - description: Must be provided or else that transaction will not be accepted. - validFrom: If not provided then the default value is taken from the requestors system timezone. - validTo: Specifies how long the points are valid ### Important info: If some rows are not correct it will still result in an accepted response code and be skipped. Please check the response for NotAccepted items ### Idempotency-Key: The idempotency key is a unique identifier included in the header of an HTTP request to ensure the idempotence of certain operations. An idempotent operation is one that produces the same result regardless of how many times it is executed with the same input. #### Purpose The primary purpose of the idempotency key is to enable safe retries of requests. In situations where a client needs to resend a request due to network issues or other transient failures, the idempotency key helps prevent unintended side effects by ensuring that repeated requests with the same key result in the same outcome. |

## PointAccountPointAccountGetAsync

Get the point account by point account id

- HTTP Method: `GET`
- Endpoint: `/api/v2/point-accounts/{id}`

**Parameters**

| Name | Type | Required | Description |
| :--- | :--- | :------- | :---------- |
| id   | long | ✅       | Account id  |

**Return Type**

`PointAccountModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.PointAccounts.PointAccountPointAccountGetAsync(5);

Console.WriteLine(response);
```

## PointAccountPointDefinitionAsync

## Gets a point account matched with the pointDefinitionId Gets the name, id and description for each pointDefinition

- HTTP Method: `GET`
- Endpoint: `/api/v2/point-accounts/definitions/{id}`

**Parameters**

| Name | Type | Required | Description   |
| :--- | :--- | :------- | :------------ |
| id   | long | ✅       | Definition Id |

**Return Type**

`PointDefinitionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.PointAccounts.PointAccountPointDefinitionAsync(5);

Console.WriteLine(response);
```

## PointAccountPointTransactionsAsync

- HTTP Method: `GET`
- Endpoint: `/api/v2/point-accounts/transactions/{id}`

**Parameters**

| Name | Type | Required | Description    |
| :--- | :--- | :------- | :------------- |
| id   | long | ✅       | Transaction id |

**Return Type**

`PointTransactionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.PointAccounts.PointAccountPointTransactionsAsync(7);

Console.WriteLine(response);
```

## PointAccountPointDefinitionsAsync

## Gets point definitions

- HTTP Method: `GET`
- Endpoint: `/api/v2/point-accounts/definitions`

**Parameters**

| Name   | Type | Required | Description     |
| :----- | :--- | :------- | :-------------- |
| offset | long | ❌       | Defaults to 0   |
| count  | long | ❌       | Defaults to 100 |

**Return Type**

`List<PointDefinitionModel>`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.PointAccounts.PointAccountPointDefinitionsAsync(8, 3);

Console.WriteLine(response);
```

## PointAccountPointAccountGet2Async

Gets a list of accounts by contact id

- HTTP Method: `GET`
- Endpoint: `/api/v2/point-accounts`

**Parameters**

| Name      | Type   | Required | Description     |
| :-------- | :----- | :------- | :-------------- |
| contactId | string | ✅       | Contact id      |
| offset    | long   | ❌       | Defaults to 0   |
| count     | long   | ❌       | Defaults to 100 |

**Return Type**

`PointAccountModelsResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.PointAccounts.PointAccountPointAccountGet2Async("contactId", 9, 10);

Console.WriteLine(response);
```

## PointAccountPointTransactions2Async

There are two ways to fetch the list of transactions: - Using just the accountId returns the transactions for that particular points account. If this is used, the parameters contactId and definitionId are not required. If they are given, they will just be ignored. - The other way is to specify both contactId and definitionId. Both must be given. The optional parameters offset and count can be used in both cases to paginate the results. The optional parameter filter can also be used to fetch active points, pending points or both. All parameters are added to the query string.

- HTTP Method: `GET`
- Endpoint: `/api/v2/point-accounts/transactions`

**Parameters**

| Name         | Type                                 | Required | Description                                                              |
| :----------- | :----------------------------------- | :------- | :----------------------------------------------------------------------- |
| contactId    | string                               | ❌       | Contact id - Required together with definitionId if not using account id |
| definitionId | long                                 | ❌       | Definition id - Required together with contactId if not using account id |
| accountId    | long                                 | ❌       | Account id - Required if contactId and definitionId is not provided      |
| offset       | long                                 | ❌       | Defaults to 0                                                            |
| count        | long                                 | ❌       | Defaults to 100                                                          |
| filter       | PointAccountPointTransactions2Filter | ❌       | All, Active or Pending. If not specified it will default to All.         |

**Return Type**

`PointTransactionModelsResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var response = await client.PointAccounts.PointAccountPointTransactions2Async("contactId", 5, 5, 8, 8, PointAccountPointTransactions2Filter.All);

Console.WriteLine(response);
```

## PointAccountAddPointTransactionsAsync

## Point transactions being sent to a contacts specified point account, the endpoint will able to take max 1000 transaction rows. ### The following fields should be provided and have certain rules: - contactId: Must be a Guid - amount: The amount of points, negative amounts are accepted. - definitionId: specifies to which point account each transaction should be sent to - timeStamp: If not provided then the default value is taken from the requestors system timezone. - source: Must be provided or else that specified transaction will not be accepted. - description: Must be provided or else that transaction will not be accepted. - validFrom: If not provided then the default value is taken from the requestors system timezone. - validTo: Specifies how long the points are valid ### Important info: If some rows are not correct it will still result in an accepted response code and be skipped. Please check the response for NotAccepted items ### Idempotency-Key: The idempotency key is a unique identifier included in the header of an HTTP request to ensure the idempotence of certain operations. An idempotent operation is one that produces the same result regardless of how many times it is executed with the same input. #### Purpose The primary purpose of the idempotency key is to enable safe retries of requests. In situations where a client needs to resend a request due to network issues or other transient failures, the idempotency key helps prevent unintended side effects by ensuring that repeated requests with the same key result in the same outcome.

- HTTP Method: `POST`
- Endpoint: `/api/v2/point-accounts/transactions`

**Parameters**

| Name           | Type                            | Required | Description                  |
| :------------- | :------------------------------ | :------- | :--------------------------- |
| input          | List<PointTransactionToAccount> | ✅       | The request body.            |
| idempotencyKey | string                          | ❌       | Optional, lasts for 24 hours |

**Return Type**

`PointTransactionToAccountResultModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var inputItem = new PointTransactionToAccount();
var input = new List<PointTransactionToAccount>() { inputItem };

var response = await client.PointAccounts.PointAccountAddPointTransactionsAsync(input, "Idempotency-Key");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
