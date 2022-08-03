using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DuctConnectionShape
    {
        [EnumMember(Value = "round"), Display(Name = "round")]
        round,
        [EnumMember(Value = "rectangle"), Display(Name = "rectangle")]
        rectangle,
        [EnumMember(Value = "oval"), Display(Name = "oval")]
        oval
    }
}