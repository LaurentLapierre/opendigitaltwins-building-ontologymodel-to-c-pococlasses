using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FaucetType
    {
        [EnumMember(Value = "Touchless"), Display(Name = "Touchless")]
        Touchless,
        [EnumMember(Value = "ManualOnly"), Display(Name = "ManualOnly")]
        ManualOnly
    }
}