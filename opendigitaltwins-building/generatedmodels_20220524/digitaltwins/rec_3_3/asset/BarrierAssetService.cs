using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BarrierAssetService
    {
        [EnumMember(Value = "Interior"), Display(Name = "Interior")]
        Interior,
        [EnumMember(Value = "Exterior"), Display(Name = "Exterior")]
        Exterior
    }
}