// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

public record OkResult(
    [property:
        JsonPropertyName("request"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Request_ = null
);
