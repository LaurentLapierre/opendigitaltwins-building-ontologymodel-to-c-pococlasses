using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HeatTracingType
    {
        [EnumMember(Value = "SelfRegulating"), Display(Name = "SelfRegulating")]
        SelfRegulating,
        [EnumMember(Value = "ConstantWattage"), Display(Name = "ConstantWattage")]
        ConstantWattage
    }
}