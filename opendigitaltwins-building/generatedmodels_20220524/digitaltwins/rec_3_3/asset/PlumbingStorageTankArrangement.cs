using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlumbingStorageTankArrangement
    {
        [EnumMember(Value = "Vertical"), Display(Name = "Vertical")]
        Vertical,
        [EnumMember(Value = "Horizontal"), Display(Name = "Horizontal")]
        Horizontal
    }
}