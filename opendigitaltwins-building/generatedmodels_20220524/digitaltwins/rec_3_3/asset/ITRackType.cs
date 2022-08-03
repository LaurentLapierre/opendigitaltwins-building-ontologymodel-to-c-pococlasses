using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ITRackType
    {
        [EnumMember(Value = "TwoPost"), Display(Name = "TwoPost")]
        TwoPost,
        [EnumMember(Value = "FourPost"), Display(Name = "FourPost")]
        FourPost,
        [EnumMember(Value = "Cabinet"), Display(Name = "Cabinet")]
        Cabinet
    }
}