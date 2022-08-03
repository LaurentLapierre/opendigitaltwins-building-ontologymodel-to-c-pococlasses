using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FanPoweredBoxConfiguration
    {
        [EnumMember(Value = "series"), Display(Name = "series")]
        series,
        [EnumMember(Value = "parallel"), Display(Name = "parallel")]
        parallel
    }
}