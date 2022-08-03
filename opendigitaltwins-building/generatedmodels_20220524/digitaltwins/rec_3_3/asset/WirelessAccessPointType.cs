using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WirelessAccessPointType
    {
        [EnumMember(Value = "WiFi7"), Display(Name = "WiFi7")]
        WiFi7,
        [EnumMember(Value = "WiFi6"), Display(Name = "WiFi6")]
        WiFi6,
        [EnumMember(Value = "WiFi5"), Display(Name = "WiFi5")]
        WiFi5,
        [EnumMember(Value = "WiFi4"), Display(Name = "WiFi4")]
        WiFi4
    }
}