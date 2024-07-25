// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

public record AllBonusCheckModel(
    [property:
        JsonPropertyName("redeemedOn"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? RedeemedOn = null,
    [property:
        JsonPropertyName("redeemed"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Redeemed = null,
    [property:
        JsonPropertyName("expiresOn"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ExpiresOn = null,
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    [property:
        JsonPropertyName("checkNumber"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CheckNumber = null,
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Value = null,
    [property:
        JsonPropertyName("localValues"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<object>? LocalValues = null,
    [property:
        JsonPropertyName("bonusPoints"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? BonusPoints = null
);
