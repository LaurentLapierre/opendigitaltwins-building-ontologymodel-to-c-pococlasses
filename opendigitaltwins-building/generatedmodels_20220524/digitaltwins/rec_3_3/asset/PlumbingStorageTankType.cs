using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlumbingStorageTankType
    {
        [EnumMember(Value = "HotWater"), Display(Name = "HotWater")]
        HotWater,
        [EnumMember(Value = "ChilledWater"), Display(Name = "ChilledWater")]
        ChilledWater
    }
}