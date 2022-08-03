using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ElectricalBusMaterial
    {
        [EnumMember(Value = "Copper"), Display(Name = "Copper")]
        Copper,
        [EnumMember(Value = "Aluminium"), Display(Name = "Aluminium")]
        Aluminium
    }
}