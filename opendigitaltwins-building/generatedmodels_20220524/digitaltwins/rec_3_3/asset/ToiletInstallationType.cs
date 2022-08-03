using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ToiletInstallationType
    {
        [EnumMember(Value = "WallMounted"), Display(Name = "WallMounted")]
        WallMounted,
        [EnumMember(Value = "FloorMounted"), Display(Name = "FloorMounted")]
        FloorMounted
    }
}