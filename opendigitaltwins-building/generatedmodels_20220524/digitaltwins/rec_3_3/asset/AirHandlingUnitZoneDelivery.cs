using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AirHandlingUnitZoneDelivery
    {
        [EnumMember(Value = "VAVZone"), Display(Name = "VAVZone")]
        VAVZone,
        [EnumMember(Value = "MultiZone"), Display(Name = "MultiZone")]
        MultiZone,
        [EnumMember(Value = "DirectZone"), Display(Name = "DirectZone")]
        DirectZone,
        [EnumMember(Value = "ChilledBeamZone"), Display(Name = "ChilledBeamZone")]
        ChilledBeamZone
    }
}