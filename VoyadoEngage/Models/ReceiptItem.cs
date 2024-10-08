// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using VoyadoEngage.Json;

namespace VoyadoEngage.Models;

public record ReceiptItem(
    [property: JsonPropertyName("type")] ReceiptItem.ReceiptItemType Type_,
    [property: JsonPropertyName("sku")] string Sku,
    [property: JsonPropertyName("quantity")] long Quantity,
    [property: JsonPropertyName("grossPaidPrice")] double GrossPaidPrice,
    [property: JsonPropertyName("taxAmount")] double TaxAmount,
    [property: JsonPropertyName("taxPercent")] double TaxPercent,
    [property: JsonPropertyName("articleNumber")] string ArticleNumber,
    [property: JsonPropertyName("articleName")] string ArticleName,
    [property:
        JsonPropertyName("packQuantity"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? PackQuantity = null,
    [property:
        JsonPropertyName("extraData"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ReceiptExtraDataItem>? ExtraData = null,
    [property:
        JsonPropertyName("articleGroup"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ArticleGroup = null,
    [property:
        JsonPropertyName("marginPercent"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? MarginPercent = null,
    [property:
        JsonPropertyName("awardsBonus"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? AwardsBonus = null,
    [property:
        JsonPropertyName("discounts"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ReceiptItemDiscount>? Discounts = null
)
{
    public record ReceiptItemType : ValueEnum<string>
    {
        internal ReceiptItemType(string value)
            : base(value) { }

        public ReceiptItemType()
            : base("PURCHASE") { }

        public static ReceiptItemType Purchase = new("PURCHASE");
        public static ReceiptItemType Return_ = new("RETURN");
        public static ReceiptItemType Adjustment = new("ADJUSTMENT");
    }
}
