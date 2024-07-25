// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace VoyadoEngage.Models;

public record PointTransactionModelsResult(
    [property:
        JsonPropertyName("links"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<IHypermediaLink>? Links = null,
    [property:
        JsonPropertyName("items"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<PointTransactionModel>? Items = null,
    [property:
        JsonPropertyName("totalCount"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? TotalCount = null,
    [property:
        JsonPropertyName("offset"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Offset = null,
    [property:
        JsonPropertyName("count"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Count = null
);
