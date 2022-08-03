using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilityPropertySetPhenomenon
    {
        [EnumMember(Value = "ACElectricity"), Display(Name = "ACElectricity")]
        ACElectricity,
        [EnumMember(Value = "Air"), Display(Name = "Air")]
        Air,
        [EnumMember(Value = "BlowdownWater"), Display(Name = "BlowdownWater")]
        BlowdownWater,
        [EnumMember(Value = "ChilledWater"), Display(Name = "ChilledWater")]
        ChilledWater,
        [EnumMember(Value = "Cloudage"), Display(Name = "Cloudage")]
        Cloudage,
        [EnumMember(Value = "ColdDomesticWater"), Display(Name = "ColdDomesticWater")]
        ColdDomesticWater,
        [EnumMember(Value = "CompressedAir"), Display(Name = "CompressedAir")]
        CompressedAir,
        [EnumMember(Value = "Condensate"), Display(Name = "Condensate")]
        Condensate,
        [EnumMember(Value = "CondenserWater"), Display(Name = "CondenserWater")]
        CondenserWater,
        [EnumMember(Value = "DCElectricity"), Display(Name = "DCElectricity")]
        DCElectricity,
        [EnumMember(Value = "Data"), Display(Name = "Data")]
        Data,
        [EnumMember(Value = "DeionizedWater"), Display(Name = "DeionizedWater")]
        DeionizedWater,
        [EnumMember(Value = "DieselFuel"), Display(Name = "DieselFuel")]
        DieselFuel,
        [EnumMember(Value = "Drainage"), Display(Name = "Drainage")]
        Drainage,
        [EnumMember(Value = "DriveElectricity"), Display(Name = "DriveElectricity")]
        DriveElectricity,
        [EnumMember(Value = "Electricity"), Display(Name = "Electricity")]
        Electricity,
        [EnumMember(Value = "EthernetData"), Display(Name = "EthernetData")]
        EthernetData,
        [EnumMember(Value = "ExhaustGas"), Display(Name = "ExhaustGas")]
        ExhaustGas,
        [EnumMember(Value = "Fire"), Display(Name = "Fire")]
        Fire,
        [EnumMember(Value = "FreezingRainPrecipitation"), Display(Name = "FreezingRainPrecipitation")]
        FreezingRainPrecipitation,
        [EnumMember(Value = "FrostIce"), Display(Name = "FrostIce")]
        FrostIce,
        [EnumMember(Value = "Fuel"), Display(Name = "Fuel")]
        Fuel,
        [EnumMember(Value = "FuelOilFuel"), Display(Name = "FuelOilFuel")]
        FuelOilFuel,
        [EnumMember(Value = "GasolineFuel"), Display(Name = "GasolineFuel")]
        GasolineFuel,
        [EnumMember(Value = "HailPrecipitation"), Display(Name = "HailPrecipitation")]
        HailPrecipitation,
        [EnumMember(Value = "HighTemperatureHotWater"), Display(Name = "HighTemperatureHotWater")]
        HighTemperatureHotWater,
        [EnumMember(Value = "HotDomesticWater"), Display(Name = "HotDomesticWater")]
        HotDomesticWater,
        [EnumMember(Value = "HotWater"), Display(Name = "HotWater")]
        HotWater,
        [EnumMember(Value = "Ice"), Display(Name = "Ice")]
        Ice,
        [EnumMember(Value = "InfraredLight"), Display(Name = "InfraredLight")]
        InfraredLight,
        [EnumMember(Value = "IrrigationWater"), Display(Name = "IrrigationWater")]
        IrrigationWater,
        [EnumMember(Value = "Light"), Display(Name = "Light")]
        Light,
        [EnumMember(Value = "LiquidPropaneFuel"), Display(Name = "LiquidPropaneFuel")]
        LiquidPropaneFuel,
        [EnumMember(Value = "LowTemperatureHotWater"), Display(Name = "LowTemperatureHotWater")]
        LowTemperatureHotWater,
        [EnumMember(Value = "MakeupWater"), Display(Name = "MakeupWater")]
        MakeupWater,
        [EnumMember(Value = "MediumTemperatureHotWater"), Display(Name = "MediumTemperatureHotWater")]
        MediumTemperatureHotWater,
        [EnumMember(Value = "NaturalGasFuel"), Display(Name = "NaturalGasFuel")]
        NaturalGasFuel,
        [EnumMember(Value = "NonPotableDomesticWater"), Display(Name = "NonPotableDomesticWater")]
        NonPotableDomesticWater,
        [EnumMember(Value = "Object"), Display(Name = "Object")]
        Object,
        [EnumMember(Value = "People"), Display(Name = "People")]
        People,
        [EnumMember(Value = "Precipitation"), Display(Name = "Precipitation")]
        Precipitation,
        [EnumMember(Value = "RainPrecipitation"), Display(Name = "RainPrecipitation")]
        RainPrecipitation,
        [EnumMember(Value = "Refrigerant"), Display(Name = "Refrigerant")]
        Refrigerant,
        [EnumMember(Value = "SleetPrecipitation"), Display(Name = "SleetPrecipitation")]
        SleetPrecipitation,
        [EnumMember(Value = "Smoke"), Display(Name = "Smoke")]
        Smoke,
        [EnumMember(Value = "SnowPrecipitation"), Display(Name = "SnowPrecipitation")]
        SnowPrecipitation,
        [EnumMember(Value = "Solar"), Display(Name = "Solar")]
        Solar,
        [EnumMember(Value = "Sound"), Display(Name = "Sound")]
        Sound,
        [EnumMember(Value = "SprinklerWater"), Display(Name = "SprinklerWater")]
        SprinklerWater,
        [EnumMember(Value = "Steam"), Display(Name = "Steam")]
        Steam,
        [EnumMember(Value = "StormDrainage"), Display(Name = "StormDrainage")]
        StormDrainage,
        [EnumMember(Value = "UltravioletLight"), Display(Name = "UltravioletLight")]
        UltravioletLight,
        [EnumMember(Value = "Urea"), Display(Name = "Urea")]
        Urea,
        [EnumMember(Value = "WasteVentDrainage"), Display(Name = "WasteVentDrainage")]
        WasteVentDrainage,
        [EnumMember(Value = "Water"), Display(Name = "Water")]
        Water,
        [EnumMember(Value = "WiFiData"), Display(Name = "WiFiData")]
        WiFiData,
        [EnumMember(Value = "Wind"), Display(Name = "Wind")]
        Wind
    }
}