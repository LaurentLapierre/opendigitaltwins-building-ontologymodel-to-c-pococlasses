using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlumbingExpansionTankType
    {
        [EnumMember(Value = "Diaphragm"), Display(Name = "Diaphragm")]
        Diaphragm,
        [EnumMember(Value = "Compression"), Display(Name = "Compression")]
        Compression,
        [EnumMember(Value = "Bladder"), Display(Name = "Bladder")]
        Bladder
    }
}