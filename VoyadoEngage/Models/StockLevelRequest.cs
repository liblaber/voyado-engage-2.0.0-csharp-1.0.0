// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

public record StockLevelRequest(
    [property: JsonPropertyName("sku"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Sku = null,
    [property:
        JsonPropertyName("locale"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Locale = null,
    [property:
        JsonPropertyName("quantity"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Quantity = null,
    [property:
        JsonPropertyName("externalId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ExternalId = null
);
