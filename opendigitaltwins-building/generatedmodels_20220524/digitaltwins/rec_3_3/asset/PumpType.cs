using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PumpType
    {
        [EnumMember(Value = "vertical"), Display(Name = "vertical")]
        vertical,
        [EnumMember(Value = "inline"), Display(Name = "inline")]
        inline
    }
}