using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HVACHeatingMethodType
    {
        [EnumMember(Value = "Steam"), Display(Name = "Steam")]
        Steam,
        [EnumMember(Value = "HotWater"), Display(Name = "HotWater")]
        HotWater,
        [EnumMember(Value = "Gas"), Display(Name = "Gas")]
        Gas,
        [EnumMember(Value = "Electric"), Display(Name = "Electric")]
        Electric
    }
}