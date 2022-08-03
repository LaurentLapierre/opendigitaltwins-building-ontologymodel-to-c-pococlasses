using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AirHandlingUnitDischargeDuctworkConfiguration
    {
        [EnumMember(Value = "TripleDuct"), Display(Name = "TripleDuct")]
        TripleDuct,
        [EnumMember(Value = "SingleDuct"), Display(Name = "SingleDuct")]
        SingleDuct,
        [EnumMember(Value = "DualDuct"), Display(Name = "DualDuct")]
        DualDuct
    }
}