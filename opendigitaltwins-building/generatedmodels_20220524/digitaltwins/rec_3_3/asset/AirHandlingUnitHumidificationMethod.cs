using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AirHandlingUnitHumidificationMethod
    {
        [EnumMember(Value = "Ultrasonic"), Display(Name = "Ultrasonic")]
        Ultrasonic,
        [EnumMember(Value = "Steam"), Display(Name = "Steam")]
        Steam,
        [EnumMember(Value = "None"), Display(Name = "None")]
        None,
        [EnumMember(Value = "Adiabatic"), Display(Name = "Adiabatic")]
        Adiabatic
    }
}