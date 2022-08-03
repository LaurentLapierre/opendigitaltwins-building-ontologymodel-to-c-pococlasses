using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilityPropertySetPosition
    {
        [EnumMember(Value = "Azimuth"), Display(Name = "Azimuth")]
        Azimuth,
        [EnumMember(Value = "Bypass"), Display(Name = "Bypass")]
        Bypass,
        [EnumMember(Value = "Circulating"), Display(Name = "Circulating")]
        Circulating,
        [EnumMember(Value = "Delta"), Display(Name = "Delta")]
        Delta,
        [EnumMember(Value = "Discharge"), Display(Name = "Discharge")]
        Discharge,
        [EnumMember(Value = "Download"), Display(Name = "Download")]
        Download,
        [EnumMember(Value = "Economizer"), Display(Name = "Economizer")]
        Economizer,
        [EnumMember(Value = "Entering"), Display(Name = "Entering")]
        Entering,
        [EnumMember(Value = "Exhaust"), Display(Name = "Exhaust")]
        Exhaust,
        [EnumMember(Value = "Export"), Display(Name = "Export")]
        Export,
        [EnumMember(Value = "Header"), Display(Name = "Header")]
        Header,
        [EnumMember(Value = "Import"), Display(Name = "Import")]
        Import,
        [EnumMember(Value = "Input"), Display(Name = "Input")]
        Input,
        [EnumMember(Value = "Inside"), Display(Name = "Inside")]
        Inside,
        [EnumMember(Value = "Leaving"), Display(Name = "Leaving")]
        Leaving,
        [EnumMember(Value = "Mixed"), Display(Name = "Mixed")]
        Mixed,
        [EnumMember(Value = "Net"), Display(Name = "Net")]
        Net,
        [EnumMember(Value = "Output"), Display(Name = "Output")]
        Output,
        [EnumMember(Value = "Outside"), Display(Name = "Outside")]
        Outside,
        [EnumMember(Value = "Return"), Display(Name = "Return")]
        Return,
        [EnumMember(Value = "Supply"), Display(Name = "Supply")]
        Supply,
        [EnumMember(Value = "Underfloor"), Display(Name = "Underfloor")]
        Underfloor,
        [EnumMember(Value = "Upload"), Display(Name = "Upload")]
        Upload,
        [EnumMember(Value = "Zenith"), Display(Name = "Zenith")]
        Zenith,
        [EnumMember(Value = "Zone"), Display(Name = "Zone")]
        Zone
    }
}