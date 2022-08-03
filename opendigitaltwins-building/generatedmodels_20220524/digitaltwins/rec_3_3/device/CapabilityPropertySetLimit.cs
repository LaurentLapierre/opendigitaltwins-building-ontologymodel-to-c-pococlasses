using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilityPropertySetLimit
    {
        [EnumMember(Value = "Maximum"), Display(Name = "Maximum")]
        Maximum,
        [EnumMember(Value = "Minimum"), Display(Name = "Minimum")]
        Minimum
    }
}