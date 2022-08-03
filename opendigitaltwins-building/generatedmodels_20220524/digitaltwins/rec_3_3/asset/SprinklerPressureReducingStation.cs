using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerPressureReducingStation : SprinklerValve, IEquatable<SprinklerPressureReducingStation>
    {
        public SprinklerPressureReducingStation()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerPressureReducingStation;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerPressureReducingStation);
        }

        public bool Equals(SprinklerPressureReducingStation? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerPressureReducingStation? left, SprinklerPressureReducingStation? right)
        {
            return EqualityComparer<SprinklerPressureReducingStation?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerPressureReducingStation? left, SprinklerPressureReducingStation? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}