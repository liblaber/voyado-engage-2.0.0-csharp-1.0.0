// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

public record OrderFee(
    [property: JsonPropertyName("value")] double Value,
    [property: JsonPropertyName("tax"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        double? Tax = null,
    [property:
        JsonPropertyName("taxPercent"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? TaxPercent = null
);
