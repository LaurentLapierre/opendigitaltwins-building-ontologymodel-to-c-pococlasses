using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CondensingUnitType
    {
        [EnumMember(Value = "WaterCooled"), Display(Name = "WaterCooled")]
        WaterCooled,
        [EnumMember(Value = "AirCooled"), Display(Name = "AirCooled")]
        AirCooled
    }
}