using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilityPropertySetHVACMode
    {
        [EnumMember(Value = "Cooldown"), Display(Name = "Cooldown")]
        Cooldown,
        [EnumMember(Value = "Cooling"), Display(Name = "Cooling")]
        Cooling,
        [EnumMember(Value = "Depressurize"), Display(Name = "Depressurize")]
        Depressurize,
        [EnumMember(Value = "Economizing"), Display(Name = "Economizing")]
        Economizing,
        [EnumMember(Value = "Heating"), Display(Name = "Heating")]
        Heating,
        [EnumMember(Value = "Manual"), Display(Name = "Manual")]
        Manual,
        [EnumMember(Value = "Pressurize"), Display(Name = "Pressurize")]
        Pressurize,
        [EnumMember(Value = "Purge"), Display(Name = "Purge")]
        Purge,
        [EnumMember(Value = "Reheat"), Display(Name = "Reheat")]
        Reheat,
        [EnumMember(Value = "Warmup"), Display(Name = "Warmup")]
        Warmup
    }
}