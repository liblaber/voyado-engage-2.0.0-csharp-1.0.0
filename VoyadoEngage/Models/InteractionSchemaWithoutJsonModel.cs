// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

public record InteractionSchemaWithoutJsonModel(
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    [property:
        JsonPropertyName("displayName"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? DisplayName = null
);
