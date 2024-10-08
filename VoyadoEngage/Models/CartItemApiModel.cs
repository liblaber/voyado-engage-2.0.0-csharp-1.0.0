// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

/// <summary>Cart item model</summary>
public record CartItemApiModel(
    /// <value>Stock keeping unit (article number)</value>
    [property:
        JsonPropertyName("sku"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Sku = null,
    /// <value>Quantity</value>
    [property:
        JsonPropertyName("quantity"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Quantity = null
);
