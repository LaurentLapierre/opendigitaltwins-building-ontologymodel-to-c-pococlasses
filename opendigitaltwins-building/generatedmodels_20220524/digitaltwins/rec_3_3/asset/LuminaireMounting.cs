using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LuminaireMounting
    {
        [EnumMember(Value = "WallMount"), Display(Name = "WallMount")]
        WallMount,
        [EnumMember(Value = "Recessed"), Display(Name = "Recessed")]
        Recessed,
        [EnumMember(Value = "Pendant"), Display(Name = "Pendant")]
        Pendant
    }
}