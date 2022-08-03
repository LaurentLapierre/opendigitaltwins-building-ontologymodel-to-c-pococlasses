using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AirHandlingUnitVentilationStrategy
    {
        [EnumMember(Value = "None"), Display(Name = "None")]
        None,
        [EnumMember(Value = "Economizing"), Display(Name = "Economizing")]
        Economizing,
        [EnumMember(Value = "DemandEconomizing"), Display(Name = "DemandEconomizing")]
        DemandEconomizing,
        [EnumMember(Value = "Demand"), Display(Name = "Demand")]
        Demand
    }
}