// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

public record InteractionSchemaResponseSelf(
    [property:
        JsonPropertyName("href"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Href = null,
    [property:
        JsonPropertyName("created"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Created = null
);
