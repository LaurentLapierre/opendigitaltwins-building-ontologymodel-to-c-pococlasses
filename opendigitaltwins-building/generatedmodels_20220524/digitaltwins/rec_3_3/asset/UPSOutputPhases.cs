using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UPSOutputPhases
    {
        [EnumMember(Value = "Three"), Display(Name = "Three")]
        Three,
        [EnumMember(Value = "One"), Display(Name = "One")]
        One
    }
}