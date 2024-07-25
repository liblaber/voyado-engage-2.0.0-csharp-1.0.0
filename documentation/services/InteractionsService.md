# InteractionsService

A list of all methods in the `InteractionsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                 | Description                                                                                                                                                                                                                                                                            |
| :---------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [InteractionGetInteractionAsync](#interactiongetinteractionasync)       | Retrieve a specific Interaction by providing the interactionId.                                                                                                                                                                                                                        |
| [InteractionDeleteInteractionAsync](#interactiondeleteinteractionasync) | Delete a specific Interaction by providing the interactionId.                                                                                                                                                                                                                          |
| [InteractionGetInteractionsAsync](#interactiongetinteractionsasync)     | Retrieve multiple Interactions of a specified type connected to a specific contactId. Both schemaId and contactId are required. The continuation parameter can be used to access the next page when there are more than 50 records available. This token can be found in the response. |
| [InteractionCreateInteractionAsync](#interactioncreateinteractionasync) | Create a new Interaction connected to a specific contactId.                                                                                                                                                                                                                            |

## InteractionGetInteractionAsync

Retrieve a specific Interaction by providing the interactionId.

- HTTP Method: `GET`
- Endpoint: `/api/v2/interactions/{interactionId}`

**Parameters**

| Name          | Type   | Required | Description |
| :------------ | :----- | :------- | :---------- |
| interactionId | string | ✅       |             |

**Return Type**

`InteractionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Interactions.InteractionGetInteractionAsync("interactionId");

Console.WriteLine(response);
```

## InteractionDeleteInteractionAsync

Delete a specific Interaction by providing the interactionId.

- HTTP Method: `DELETE`
- Endpoint: `/api/v2/interactions/{interactionId}`

**Parameters**

| Name          | Type   | Required | Description |
| :------------ | :----- | :------- | :---------- |
| interactionId | string | ✅       |             |

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

await client.Interactions.InteractionDeleteInteractionAsync("interactionId");
```

## InteractionGetInteractionsAsync

Retrieve multiple Interactions of a specified type connected to a specific contactId. Both schemaId and contactId are required. The continuation parameter can be used to access the next page when there are more than 50 records available. This token can be found in the response.

- HTTP Method: `GET`
- Endpoint: `/api/v2/interactions`

**Parameters**

| Name         | Type   | Required | Description |
| :----------- | :----- | :------- | :---------- |
| contactId    | string | ✅       |             |
| schemaId     | string | ✅       |             |
| continuation | string | ❌       |             |

**Return Type**

`InteractionPage`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Interactions.InteractionGetInteractionsAsync("contactId", "schemaId", "continuation");

Console.WriteLine(response);
```

## InteractionCreateInteractionAsync

Create a new Interaction connected to a specific contactId.

- HTTP Method: `POST`
- Endpoint: `/api/v2/interactions`

**Parameters**

| Name  | Type   | Required | Description       |
| :---- | :----- | :------- | :---------------- |
| input | object | ✅       | The request body. |

**Return Type**

`InteractionCreateResponse`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Interactions.InteractionCreateInteractionAsync(new object {});

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
