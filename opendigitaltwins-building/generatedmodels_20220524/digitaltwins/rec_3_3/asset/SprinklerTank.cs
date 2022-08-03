using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerTank : Tank, IEquatable<SprinklerTank>
    {
        public SprinklerTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerTank;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerTank);
        }

        public bool Equals(SprinklerTank? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerTank? left, SprinklerTank? right)
        {
            return EqualityComparer<SprinklerTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerTank? left, SprinklerTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}