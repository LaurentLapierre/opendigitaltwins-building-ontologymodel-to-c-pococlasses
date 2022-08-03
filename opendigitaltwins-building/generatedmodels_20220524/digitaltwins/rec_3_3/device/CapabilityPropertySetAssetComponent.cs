using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilityPropertySetAssetComponent
    {
        [EnumMember(Value = "Battery"), Display(Name = "Battery")]
        Battery,
        [EnumMember(Value = "Coil"), Display(Name = "Coil")]
        Coil,
        [EnumMember(Value = "Compressor"), Display(Name = "Compressor")]
        Compressor,
        [EnumMember(Value = "Condenser"), Display(Name = "Condenser")]
        Condenser,
        [EnumMember(Value = "Damper"), Display(Name = "Damper")]
        Damper,
        [EnumMember(Value = "Evaporator"), Display(Name = "Evaporator")]
        Evaporator,
        [EnumMember(Value = "Fan"), Display(Name = "Fan")]
        Fan,
        [EnumMember(Value = "Filter"), Display(Name = "Filter")]
        Filter,
        [EnumMember(Value = "Motor"), Display(Name = "Motor")]
        Motor,
        [EnumMember(Value = "VFD"), Display(Name = "VFD")]
        VFD,
        [EnumMember(Value = "coolingCoil"), Display(Name = "coolingCoil")]
        coolingCoil,
        [EnumMember(Value = "heatingCoil"), Display(Name = "heatingCoil")]
        heatingCoil
    }
}