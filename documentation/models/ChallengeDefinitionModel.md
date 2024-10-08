# ChallengeDefinitionModel

**Properties**

| Name                        | Type                           | Required | Description |
| :-------------------------- | :----------------------------- | :------- | :---------- |
| CheckpointAssignOn\_        | CheckpointAssignOn             | ❌       |             |
| CheckpointAssignOnAmount    | double                         | ❌       |             |
| CreatedBy                   | string                         | ❌       |             |
| CreatedOn                   | string                         | ❌       |             |
| Description                 | string                         | ❌       |             |
| ExpirationMonths            | long                           | ❌       |             |
| Id                          | string                         | ❌       |             |
| IsContactConsentRequired    | bool                           | ❌       |             |
| IsScheduled                 | bool                           | ❌       |             |
| ModifiedBy                  | string                         | ❌       |             |
| ModifiedOn                  | string                         | ❌       |             |
| Name                        | string                         | ❌       |             |
| RequiredNumberOfCheckpoints | long                           | ❌       |             |
| ScheduledFrom               | string                         | ❌       |             |
| ScheduledTo                 | string                         | ❌       |             |
| Status                      | ChallengeDefinitionModelStatus | ❌       |             |
| Links                       | List`<IHypermediaLink>`        | ❌       |             |

# CheckpointAssignOn

**Properties**

| Name                | Type   | Required | Description           |
| :------------------ | :----- | :------- | :-------------------- |
| None                | string | ✅       | "None"                |
| ReceiptTotal        | string | ✅       | "ReceiptTotal"        |
| ReceiptLineQuantity | string | ✅       | "ReceiptLineQuantity" |
| ReceiptLineTotal    | string | ✅       | "ReceiptLineTotal"    |

# ChallengeDefinitionModelStatus

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| All       | string | ✅       | "All"       |
| Active    | string | ✅       | "Active"    |
| Draft     | string | ✅       | "Draft"     |
| Scheduled | string | ✅       | "Scheduled" |
| Ended     | string | ✅       | "Ended"     |

<!-- This file was generated by liblab | https://liblab.com/ -->
