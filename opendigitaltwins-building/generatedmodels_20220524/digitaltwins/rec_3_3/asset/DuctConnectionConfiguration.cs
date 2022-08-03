using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DuctConnectionConfiguration
    {
        [EnumMember(Value = "single"), Display(Name = "single")]
        single,
        [EnumMember(Value = "dual"), Display(Name = "dual")]
        dual
    }
}