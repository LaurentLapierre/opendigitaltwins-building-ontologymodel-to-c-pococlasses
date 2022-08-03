using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FanDriveType
    {
        [EnumMember(Value = "Direct"), Display(Name = "Direct")]
        Direct,
        [EnumMember(Value = "Belt"), Display(Name = "Belt")]
        Belt
    }
}