// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using VoyadoEngage.Json;

namespace VoyadoEngage.Models;

public record BonusPointTransactionModel(
    [property:
        JsonPropertyName("amount"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Amount = null,
    [property:
        JsonPropertyName("transactionDateTime"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? TransactionDateTime = null,
    [property:
        JsonPropertyName("description"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Description = null,
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        BonusPointTransactionModel.BonusPointTransactionModelType? Type_ = null,
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    [property:
        JsonPropertyName("automationBonusAdjustmentReason"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? AutomationBonusAdjustmentReason = null
)
{
    public record BonusPointTransactionModelType : ValueEnum<string>
    {
        internal BonusPointTransactionModelType(string value)
            : base(value) { }

        public BonusPointTransactionModelType()
            : base("Purchase") { }

        public static BonusPointTransactionModelType Purchase = new("Purchase");
        public static BonusPointTransactionModelType Adjustment = new("Adjustment");
        public static BonusPointTransactionModelType Recruitment = new("Recruitment");
        public static BonusPointTransactionModelType PurchaseReduction = new("PurchaseReduction");
        public static BonusPointTransactionModelType Return_ = new("Return");
        public static BonusPointTransactionModelType BonusCheck = new("BonusCheck");
        public static BonusPointTransactionModelType DueDate = new("DueDate");
        public static BonusPointTransactionModelType StartBonus = new("StartBonus");
        public static BonusPointTransactionModelType BonusPromotion = new("BonusPromotion");
        public static BonusPointTransactionModelType BonusPromotionReturn =
            new("BonusPromotionReturn");
        public static BonusPointTransactionModelType FromAutomation = new("FromAutomation");
        public static BonusPointTransactionModelType BonusBalanceAdjustment =
            new("BonusBalanceAdjustment");
        public static BonusPointTransactionModelType PurchaseWithPoints = new("PurchaseWithPoints");
    }
}
