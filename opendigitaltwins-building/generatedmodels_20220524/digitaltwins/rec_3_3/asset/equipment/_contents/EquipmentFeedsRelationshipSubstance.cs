using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EquipmentFeedsRelationshipSubstance
    {
        [EnumMember(Value = "Water"), Display(Name = "Water")]
        Water,
        [EnumMember(Value = "WasteVentDrainage"), Display(Name = "WasteVentDrainage")]
        WasteVentDrainage,
        [EnumMember(Value = "TransferAir"), Display(Name = "TransferAir")]
        TransferAir,
        [EnumMember(Value = "SupplyAir"), Display(Name = "SupplyAir")]
        SupplyAir,
        [EnumMember(Value = "StormDrainage"), Display(Name = "StormDrainage")]
        StormDrainage,
        [EnumMember(Value = "Steam"), Display(Name = "Steam")]
        Steam,
        [EnumMember(Value = "SprinklerWater"), Display(Name = "SprinklerWater")]
        SprinklerWater,
        [EnumMember(Value = "ReturnAir"), Display(Name = "ReturnAir")]
        ReturnAir,
        [EnumMember(Value = "Refrig"), Display(Name = "Refrig")]
        Refrig,
        [EnumMember(Value = "RecircHotDomesticWater"), Display(Name = "RecircHotDomesticWater")]
        RecircHotDomesticWater,
        [EnumMember(Value = "Propane"), Display(Name = "Propane")]
        Propane,
        [EnumMember(Value = "People"), Display(Name = "People")]
        People,
        [EnumMember(Value = "OutsideAir"), Display(Name = "OutsideAir")]
        OutsideAir,
        [EnumMember(Value = "NonPotableDomesticWater"), Display(Name = "NonPotableDomesticWater")]
        NonPotableDomesticWater,
        [EnumMember(Value = "NaturalGas"), Display(Name = "NaturalGas")]
        NaturalGas,
        [EnumMember(Value = "MakeupWater"), Display(Name = "MakeupWater")]
        MakeupWater,
        [EnumMember(Value = "Light"), Display(Name = "Light")]
        Light,
        [EnumMember(Value = "IrrigationWater"), Display(Name = "IrrigationWater")]
        IrrigationWater,
        [EnumMember(Value = "HotWater"), Display(Name = "HotWater")]
        HotWater,
        [EnumMember(Value = "HotDomesticWater"), Display(Name = "HotDomesticWater")]
        HotDomesticWater,
        [EnumMember(Value = "GreaseExhaustAir"), Display(Name = "GreaseExhaustAir")]
        GreaseExhaustAir,
        [EnumMember(Value = "Gasoline"), Display(Name = "Gasoline")]
        Gasoline,
        [EnumMember(Value = "FuelOil"), Display(Name = "FuelOil")]
        FuelOil,
        [EnumMember(Value = "Freight"), Display(Name = "Freight")]
        Freight,
        [EnumMember(Value = "ExhaustAir"), Display(Name = "ExhaustAir")]
        ExhaustAir,
        [EnumMember(Value = "Ethernet"), Display(Name = "Ethernet")]
        Ethernet,
        [EnumMember(Value = "DriveElec"), Display(Name = "DriveElec")]
        DriveElec,
        [EnumMember(Value = "Diesel"), Display(Name = "Diesel")]
        Diesel,
        [EnumMember(Value = "DCElec"), Display(Name = "DCElec")]
        DCElec,
        [EnumMember(Value = "CondenserWater"), Display(Name = "CondenserWater")]
        CondenserWater,
        [EnumMember(Value = "Condensate"), Display(Name = "Condensate")]
        Condensate,
        [EnumMember(Value = "ColdDomesticWater"), Display(Name = "ColdDomesticWater")]
        ColdDomesticWater,
        [EnumMember(Value = "ChilledWater"), Display(Name = "ChilledWater")]
        ChilledWater,
        [EnumMember(Value = "BlowdownWater"), Display(Name = "BlowdownWater")]
        BlowdownWater,
        [EnumMember(Value = "Air"), Display(Name = "Air")]
        Air,
        [EnumMember(Value = "ACElec"), Display(Name = "ACElec")]
        ACElec
    }
}