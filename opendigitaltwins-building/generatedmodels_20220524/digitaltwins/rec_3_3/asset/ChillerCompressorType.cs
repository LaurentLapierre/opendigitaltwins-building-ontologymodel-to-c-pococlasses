using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ChillerCompressorType
    {
        [EnumMember(Value = "Scroll"), Display(Name = "Scroll")]
        Scroll,
        [EnumMember(Value = "Screw"), Display(Name = "Screw")]
        Screw,
        [EnumMember(Value = "Reciprocol"), Display(Name = "Reciprocol")]
        Reciprocol,
        [EnumMember(Value = "Centrifugal"), Display(Name = "Centrifugal")]
        Centrifugal,
        [EnumMember(Value = "Absorption"), Display(Name = "Absorption")]
        Absorption
    }
}