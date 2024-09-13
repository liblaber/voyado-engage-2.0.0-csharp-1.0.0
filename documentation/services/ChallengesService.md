# ChallengesService

A list of all methods in the `ChallengesService` service. Click on the method name to view detailed information about that method.

| Methods                                                                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| :------------------------------------------------------------------------------------ | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [ChallengeGetChallengeByIdAsync](#challengegetchallengebyidasync)                     | Get an challenge assignment by id.                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [ChallengeGetChallengeDefinitionByIdAsync](#challengegetchallengedefinitionbyidasync) | Get a challenge definition by id.                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [ChallengeGetChallengeDefinitionsAsync](#challengegetchallengedefinitionsasync)       | Get a list of all the challenge definitions.                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [ChallengeGetChallengesAsync](#challengegetchallengesasync)                           | Search for challenges for a contact.                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [ChallengeAddChallengeCheckPointsAsync](#challengeaddchallengecheckpointsasync)       | Send in a list of checkpoints to be assigned to a some challenge for a number of contacts, the endpoint will able to take max 1000 checkpoint rows. ### The following fields should be provided: - definitionId: Must be a Guid - contactId: Must be a Guid - checkPointAmount: Number of checkpoints to assign to the challenge ### Important info: If some rows are not correct it will still result in an accepted response code and be skipped. Please check the response for NotAccepted items |
| [ChallengeConsentAsync](#challengeconsentasync)                                       | Will assign the challenge for the contact and return true. If the contact already has been assigned for the challenge it will also return true.                                                                                                                                                                                                                                                                                                                                                     |

## ChallengeGetChallengeByIdAsync

Get an challenge assignment by id.

- HTTP Method: `GET`
- Endpoint: `/api/v2/challenges/{id}`

**Parameters**

| Name | Type   | Required | Description   |
| :--- | :----- | :------- | :------------ |
| id   | string | ✅       | Assignment id |

**Return Type**

`ChallengeAssignmentModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Challenges.ChallengeGetChallengeByIdAsync("id");

Console.WriteLine(response);
```

## ChallengeGetChallengeDefinitionByIdAsync

Get a challenge definition by id.

- HTTP Method: `GET`
- Endpoint: `/api/v2/challenges/definitions/{id}`

**Parameters**

| Name | Type   | Required | Description   |
| :--- | :----- | :------- | :------------ |
| id   | string | ✅       | Definition id |

**Return Type**

`ChallengeDefinitionModel`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Challenges.ChallengeGetChallengeDefinitionByIdAsync("id");

Console.WriteLine(response);
```

## ChallengeGetChallengeDefinitionsAsync

Get a list of all the challenge definitions.

- HTTP Method: `GET`
- Endpoint: `/api/v2/challenges/definitions`

**Parameters**

| Name   | Type                                   | Required | Description                                                          |
| :----- | :------------------------------------- | :------- | :------------------------------------------------------------------- |
| offset | long                                   | ❌       | Defaults to 0                                                        |
| count  | long                                   | ❌       | Defaults to 100                                                      |
| status | ChallengeGetChallengeDefinitionsStatus | ❌       | All, Active, Draft or Ended. If not specified it will default to All |

**Return Type**

`ChallengeDefinitionModelsResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var response = await client.Challenges.ChallengeGetChallengeDefinitionsAsync(2, 1, ChallengeGetChallengeDefinitionsStatus.All);

Console.WriteLine(response);
```

## ChallengeGetChallengesAsync

Search for challenges for a contact.

- HTTP Method: `GET`
- Endpoint: `/api/v2/challenges`

**Parameters**

| Name         | Type                         | Required | Description                                                                     |
| :----------- | :--------------------------- | :------- | :------------------------------------------------------------------------------ |
| contactId    | string                       | ✅       | Contact id                                                                      |
| definitionId | string                       | ❌       | Definition id - Optional to limit to a certain challenge definition             |
| offset       | long                         | ❌       | Defaults to 0                                                                   |
| count        | long                         | ❌       | Defaults to 100                                                                 |
| filter       | ChallengeGetChallengesFilter | ❌       | All, Active, Completed or NotCompleted. If not specified it will default to All |

**Return Type**

`ChallengeAssignmentModelsResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var response = await client.Challenges.ChallengeGetChallengesAsync("contactId", "definitionId", 3, 1, ChallengeGetChallengesFilter.All);

Console.WriteLine(response);
```

## ChallengeAddChallengeCheckPointsAsync

Send in a list of checkpoints to be assigned to a some challenge for a number of contacts, the endpoint will able to take max 1000 checkpoint rows. ### The following fields should be provided: - definitionId: Must be a Guid - contactId: Must be a Guid - checkPointAmount: Number of checkpoints to assign to the challenge ### Important info: If some rows are not correct it will still result in an accepted response code and be skipped. Please check the response for NotAccepted items

- HTTP Method: `POST`
- Endpoint: `/api/v2/challenges/checkpoints`

**Parameters**

| Name  | Type                           | Required | Description       |
| :---- | :----------------------------- | :------- | :---------------- |
| input | List`<ChallengeCheckPointDto>` | ✅       | The request body. |

**Return Type**

`AddCheckpointToChallengeAssignmentResult`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;
using VoyadoEngage.Models;

var client = new VoyadoEngageClient();

var inputItem = new ChallengeCheckPointDto();
var input = new List<ChallengeCheckPointDto>() { inputItem };

var response = await client.Challenges.ChallengeAddChallengeCheckPointsAsync(input);

Console.WriteLine(response);
```

## ChallengeConsentAsync

Will assign the challenge for the contact and return true. If the contact already has been assigned for the challenge it will also return true.

- HTTP Method: `POST`
- Endpoint: `/api/v2/challenges/definitions/{id}/assign`

**Parameters**

| Name      | Type   | Required | Description   |
| :-------- | :----- | :------- | :------------ |
| id        | string | ✅       | Definition id |
| contactId | string | ✅       | Contact id    |

**Return Type**

`bool`

**Example Usage Code Snippet**

```csharp
using VoyadoEngage;

var client = new VoyadoEngageClient();

var response = await client.Challenges.ChallengeConsentAsync("id", "contactId");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
