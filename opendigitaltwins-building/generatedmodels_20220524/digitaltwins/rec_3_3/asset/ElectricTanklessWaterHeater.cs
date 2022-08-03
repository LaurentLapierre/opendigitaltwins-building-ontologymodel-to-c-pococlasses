using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricTanklessWaterHeater : TanklessWaterHeater, IEquatable<ElectricTanklessWaterHeater>
    {
        public ElectricTanklessWaterHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricTanklessWaterHeater;1";
        [JsonPropertyName("powerInput")]
        public double? PowerInput { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricTanklessWaterHeater);
        }

        public bool Equals(ElectricTanklessWaterHeater? other)
        {
            return other is not null && base.Equals(other) && PowerInput == other.PowerInput;
        }

        public static bool operator ==(ElectricTanklessWaterHeater? left, ElectricTanklessWaterHeater? right)
        {
            return EqualityComparer<ElectricTanklessWaterHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricTanklessWaterHeater? left, ElectricTanklessWaterHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PowerInput?.GetHashCode());
        }
    }
}