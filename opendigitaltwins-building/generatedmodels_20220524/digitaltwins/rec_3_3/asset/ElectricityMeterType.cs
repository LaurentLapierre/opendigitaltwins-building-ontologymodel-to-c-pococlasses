using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ElectricityMeterType
    {
        [EnumMember(Value = "DC"), Display(Name = "DC")]
        DC,
        [EnumMember(Value = "AC"), Display(Name = "AC")]
        AC
    }
}