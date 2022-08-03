using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VariableFrequencyDriveType
    {
        [EnumMember(Value = "VoltageSourceInverter"), Display(Name = "VoltageSourceInverter")]
        VoltageSourceInverter,
        [EnumMember(Value = "PulseWidthModulation"), Display(Name = "PulseWidthModulation")]
        PulseWidthModulation,
        [EnumMember(Value = "CurrentSourceInverter"), Display(Name = "CurrentSourceInverter")]
        CurrentSourceInverter
    }
}