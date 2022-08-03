using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class TankWaterHeater : WaterHeater, IEquatable<TankWaterHeater>
    {
        public TankWaterHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:TankWaterHeater;1";
        [JsonPropertyName("tankCapacity")]
        public double? TankCapacity { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as TankWaterHeater);
        }

        public bool Equals(TankWaterHeater? other)
        {
            return other is not null && base.Equals(other) && TankCapacity == other.TankCapacity;
        }

        public static bool operator ==(TankWaterHeater? left, TankWaterHeater? right)
        {
            return EqualityComparer<TankWaterHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(TankWaterHeater? left, TankWaterHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), TankCapacity?.GetHashCode());
        }
    }
}