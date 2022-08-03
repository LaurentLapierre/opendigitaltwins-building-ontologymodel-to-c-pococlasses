using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DamperService
    {
        [EnumMember(Value = "Supply"), Display(Name = "Supply")]
        Supply,
        [EnumMember(Value = "Return"), Display(Name = "Return")]
        Return,
        [EnumMember(Value = "Exhaust"), Display(Name = "Exhaust")]
        Exhaust
    }
}