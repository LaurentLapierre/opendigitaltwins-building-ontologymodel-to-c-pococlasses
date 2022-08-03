using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilityPropertySetOccupancyMode
    {
        [EnumMember(Value = "Occupied"), Display(Name = "Occupied")]
        Occupied,
        [EnumMember(Value = "Standby"), Display(Name = "Standby")]
        Standby,
        [EnumMember(Value = "Unoccupied"), Display(Name = "Unoccupied")]
        Unoccupied
    }
}