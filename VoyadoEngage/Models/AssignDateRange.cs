// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using VoyadoEngage.Json;

namespace VoyadoEngage.Models;

/// <summary>The validity time of the promotion set when assignment occured</summary>
public record AssignDateRange(
    [property: JsonPropertyName("unit")] AssignDateRange.Unit Unit_,
    [property: JsonPropertyName("amount")] long Amount
)
{
    public record Unit : ValueEnum<string>
    {
        internal Unit(string value)
            : base(value) { }

        public Unit()
            : base("Months") { }

        public static Unit Months = new("Months");
        public static Unit Days = new("Days");
    }
}
