using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ToiletTankFlushingType
    {
        [EnumMember(Value = "PressureAssisted"), Display(Name = "PressureAssisted")]
        PressureAssisted,
        [EnumMember(Value = "Gravity"), Display(Name = "Gravity")]
        Gravity
    }
}