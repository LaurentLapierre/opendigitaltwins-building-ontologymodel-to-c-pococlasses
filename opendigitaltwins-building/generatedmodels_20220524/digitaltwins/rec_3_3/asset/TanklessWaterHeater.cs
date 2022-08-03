using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class TanklessWaterHeater : WaterHeater, IEquatable<TanklessWaterHeater>
    {
        public TanklessWaterHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:TanklessWaterHeater;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as TanklessWaterHeater);
        }

        public bool Equals(TanklessWaterHeater? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TanklessWaterHeater? left, TanklessWaterHeater? right)
        {
            return EqualityComparer<TanklessWaterHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(TanklessWaterHeater? left, TanklessWaterHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}