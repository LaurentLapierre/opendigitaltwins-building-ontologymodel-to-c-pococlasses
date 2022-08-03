using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WirelessAccessPointMounting
    {
        [EnumMember(Value = "Outdoor"), Display(Name = "Outdoor")]
        Outdoor,
        [EnumMember(Value = "Indoor"), Display(Name = "Indoor")]
        Indoor
    }
}