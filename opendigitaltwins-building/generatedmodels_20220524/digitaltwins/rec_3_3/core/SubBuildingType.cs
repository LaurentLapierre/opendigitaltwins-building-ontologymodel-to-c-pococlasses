using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubBuildingType
    {
        [EnumMember(Value = "Wing"), Display(Name = "Wing")]
        Wing,
        [EnumMember(Value = "Tower"), Display(Name = "Tower")]
        Tower
    }
}