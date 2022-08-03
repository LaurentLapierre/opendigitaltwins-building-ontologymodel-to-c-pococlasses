using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AutomaticTransferSwitchTransitionType
    {
        [EnumMember(Value = "Open"), Display(Name = "Open")]
        Open,
        [EnumMember(Value = "Closed"), Display(Name = "Closed")]
        Closed
    }
}