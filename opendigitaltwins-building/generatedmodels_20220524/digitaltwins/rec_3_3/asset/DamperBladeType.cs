using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DamperBladeType
    {
        [EnumMember(Value = "Vee"), Display(Name = "Vee")]
        Vee,
        [EnumMember(Value = "Round"), Display(Name = "Round")]
        Round,
        [EnumMember(Value = "Airfoil"), Display(Name = "Airfoil")]
        Airfoil
    }
}