using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HVACShutOffValveType
    {
        [EnumMember(Value = "Gate"), Display(Name = "Gate")]
        Gate,
        [EnumMember(Value = "Butterfly"), Display(Name = "Butterfly")]
        Butterfly,
        [EnumMember(Value = "Ball"), Display(Name = "Ball")]
        Ball
    }
}