using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AirHandlingUnitAirflowModulation
    {
        [EnumMember(Value = "VariableVolume"), Display(Name = "VariableVolume")]
        VariableVolume,
        [EnumMember(Value = "ConstantVolume"), Display(Name = "ConstantVolume")]
        ConstantVolume
    }
}