using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FlushometerValveTechnology
    {
        [EnumMember(Value = "Piston"), Display(Name = "Piston")]
        Piston,
        [EnumMember(Value = "Diaphragm"), Display(Name = "Diaphragm")]
        Diaphragm
    }
}