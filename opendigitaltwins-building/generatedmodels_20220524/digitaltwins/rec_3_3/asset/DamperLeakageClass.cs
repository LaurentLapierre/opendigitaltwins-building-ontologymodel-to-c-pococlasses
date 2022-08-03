using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DamperLeakageClass
    {
        [EnumMember(Value = "III"), Display(Name = "III")]
        III,
        [EnumMember(Value = "II"), Display(Name = "II")]
        II,
        [EnumMember(Value = "I"), Display(Name = "I")]
        I
    }
}