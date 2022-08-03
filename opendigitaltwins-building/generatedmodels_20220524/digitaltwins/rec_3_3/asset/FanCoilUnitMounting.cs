using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FanCoilUnitMounting
    {
        [EnumMember(Value = "wall"), Display(Name = "wall")]
        wall,
        [EnumMember(Value = "floor"), Display(Name = "floor")]
        floor,
        [EnumMember(Value = "ceiling"), Display(Name = "ceiling")]
        ceiling
    }
}