using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AirHandlingUnitDehumidificationMethod
    {
        [EnumMember(Value = "WrapAroundCoil"), Display(Name = "WrapAroundCoil")]
        WrapAroundCoil,
        [EnumMember(Value = "TieredCooling"), Display(Name = "TieredCooling")]
        TieredCooling,
        [EnumMember(Value = "None"), Display(Name = "None")]
        None,
        [EnumMember(Value = "DualWheel"), Display(Name = "DualWheel")]
        DualWheel,
        [EnumMember(Value = "Desiccant"), Display(Name = "Desiccant")]
        Desiccant,
        [EnumMember(Value = "CoolReheat"), Display(Name = "CoolReheat")]
        CoolReheat
    }
}