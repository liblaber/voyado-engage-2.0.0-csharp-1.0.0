# BonusPointTransactionModel

**Properties**

| Name                            | Type                           | Required | Description |
| :------------------------------ | :----------------------------- | :------- | :---------- |
| Amount                          | double                         | ❌       |             |
| TransactionDateTime             | string                         | ❌       |             |
| Description                     | string                         | ❌       |             |
| Type\_                          | BonusPointTransactionModelType | ❌       |             |
| Id                              | string                         | ❌       |             |
| AutomationBonusAdjustmentReason | string                         | ❌       |             |

# BonusPointTransactionModelType

**Properties**

| Name                   | Type   | Required | Description              |
| :--------------------- | :----- | :------- | :----------------------- |
| Purchase               | string | ✅       | "Purchase"               |
| Adjustment             | string | ✅       | "Adjustment"             |
| Recruitment            | string | ✅       | "Recruitment"            |
| PurchaseReduction      | string | ✅       | "PurchaseReduction"      |
| Return\_               | string | ✅       | "Return"                 |
| BonusCheck             | string | ✅       | "BonusCheck"             |
| DueDate                | string | ✅       | "DueDate"                |
| StartBonus             | string | ✅       | "StartBonus"             |
| BonusPromotion         | string | ✅       | "BonusPromotion"         |
| BonusPromotionReturn   | string | ✅       | "BonusPromotionReturn"   |
| FromAutomation         | string | ✅       | "FromAutomation"         |
| BonusBalanceAdjustment | string | ✅       | "BonusBalanceAdjustment" |
| PurchaseWithPoints     | string | ✅       | "PurchaseWithPoints"     |

<!-- This file was generated by liblab | https://liblab.com/ -->
