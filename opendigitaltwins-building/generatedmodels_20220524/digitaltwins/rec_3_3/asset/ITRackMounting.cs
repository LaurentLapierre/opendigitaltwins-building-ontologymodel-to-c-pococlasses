using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ITRackMounting
    {
        [EnumMember(Value = "Wall"), Display(Name = "Wall")]
        Wall,
        [EnumMember(Value = "Floor"), Display(Name = "Floor")]
        Floor
    }
}