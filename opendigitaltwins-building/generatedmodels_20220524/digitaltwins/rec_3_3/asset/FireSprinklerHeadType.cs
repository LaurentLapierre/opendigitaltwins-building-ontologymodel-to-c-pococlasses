using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FireSprinklerHeadType
    {
        [EnumMember(Value = "Upright"), Display(Name = "Upright")]
        Upright,
        [EnumMember(Value = "SideWall"), Display(Name = "SideWall")]
        SideWall,
        [EnumMember(Value = "Pendant"), Display(Name = "Pendant")]
        Pendant,
        [EnumMember(Value = "ConcealedPendant"), Display(Name = "ConcealedPendant")]
        ConcealedPendant
    }
}