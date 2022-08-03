using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AutomaticTransferSwitchSwitchingMechanism
    {
        [EnumMember(Value = "Contactor"), Display(Name = "Contactor")]
        Contactor,
        [EnumMember(Value = "CircuitBreakerPowerCase"), Display(Name = "CircuitBreakerPowerCase")]
        CircuitBreakerPowerCase,
        [EnumMember(Value = "CircuitBreakerMoldedCase"), Display(Name = "CircuitBreakerMoldedCase")]
        CircuitBreakerMoldedCase
    }
}