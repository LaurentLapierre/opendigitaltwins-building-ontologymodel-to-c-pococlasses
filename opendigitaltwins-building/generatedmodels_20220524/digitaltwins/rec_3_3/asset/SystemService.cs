using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SystemService
    {
        [EnumMember(Value = "Utility"), Display(Name = "Utility")]
        Utility,
        [EnumMember(Value = "Tenant"), Display(Name = "Tenant")]
        Tenant,
        [EnumMember(Value = "Site"), Display(Name = "Site")]
        Site,
        [EnumMember(Value = "District"), Display(Name = "District")]
        District,
        [EnumMember(Value = "Building"), Display(Name = "Building")]
        Building
    }
}