using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AirHandlingUnitVentilationConfiguration
    {
        [EnumMember(Value = "OA"), Display(Name = "OA")]
        OA,
        [EnumMember(Value = "None"), Display(Name = "None")]
        None,
        [EnumMember(Value = "MixedAir"), Display(Name = "MixedAir")]
        MixedAir
    }
}