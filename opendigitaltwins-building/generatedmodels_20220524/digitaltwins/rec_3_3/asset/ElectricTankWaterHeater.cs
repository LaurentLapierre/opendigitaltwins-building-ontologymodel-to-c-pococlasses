using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricTankWaterHeater : TankWaterHeater, IEquatable<ElectricTankWaterHeater>
    {
        public ElectricTankWaterHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricTankWaterHeater;1";
        [JsonPropertyName("powerInput")]
        public double? PowerInput { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricTankWaterHeater);
        }

        public bool Equals(ElectricTankWaterHeater? other)
        {
            return other is not null && base.Equals(other) && PowerInput == other.PowerInput;
        }

        public static bool operator ==(ElectricTankWaterHeater? left, ElectricTankWaterHeater? right)
        {
            return EqualityComparer<ElectricTankWaterHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricTankWaterHeater? left, ElectricTankWaterHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PowerInput?.GetHashCode());
        }
    }
}