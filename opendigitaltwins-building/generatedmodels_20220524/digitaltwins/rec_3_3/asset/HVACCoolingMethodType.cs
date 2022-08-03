using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HVACCoolingMethodType
    {
        [EnumMember(Value = "DX"), Display(Name = "DX")]
        DX,
        [EnumMember(Value = "ChilledWater"), Display(Name = "ChilledWater")]
        ChilledWater
    }
}