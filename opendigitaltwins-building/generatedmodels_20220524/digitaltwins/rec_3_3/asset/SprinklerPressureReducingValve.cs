using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerPressureReducingValve : SprinklerValve, IEquatable<SprinklerPressureReducingValve>
    {
        public SprinklerPressureReducingValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerPressureReducingValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerPressureReducingValve);
        }

        public bool Equals(SprinklerPressureReducingValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerPressureReducingValve? left, SprinklerPressureReducingValve? right)
        {
            return EqualityComparer<SprinklerPressureReducingValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerPressureReducingValve? left, SprinklerPressureReducingValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}