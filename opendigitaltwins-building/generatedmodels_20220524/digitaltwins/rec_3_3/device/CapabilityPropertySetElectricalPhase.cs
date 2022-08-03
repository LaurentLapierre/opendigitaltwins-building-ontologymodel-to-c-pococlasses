using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilityPropertySetElectricalPhase
    {
        [EnumMember(Value = "A"), Display(Name = "A")]
        A,
        [EnumMember(Value = "AB"), Display(Name = "AB")]
        AB,
        [EnumMember(Value = "B"), Display(Name = "B")]
        B,
        [EnumMember(Value = "BC"), Display(Name = "BC")]
        BC,
        [EnumMember(Value = "C"), Display(Name = "C")]
        C,
        [EnumMember(Value = "CA"), Display(Name = "CA")]
        CA,
        [EnumMember(Value = "N"), Display(Name = "N")]
        N
    }
}