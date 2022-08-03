using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ElevatorTripDirection
    {
        [EnumMember(Value = "Up"), Display(Name = "Up")]
        Up,
        [EnumMember(Value = "Down"), Display(Name = "Down")]
        Down
    }
}