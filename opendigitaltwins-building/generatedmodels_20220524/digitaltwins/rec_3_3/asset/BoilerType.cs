using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BoilerType
    {
        [EnumMember(Value = "WaterTube"), Display(Name = "WaterTube")]
        WaterTube,
        [EnumMember(Value = "FireTube"), Display(Name = "FireTube")]
        FireTube
    }
}