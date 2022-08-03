using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FloorDrain : Drain, IEquatable<FloorDrain>
    {
        public FloorDrain()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FloorDrain;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FloorDrain);
        }

        public bool Equals(FloorDrain? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FloorDrain? left, FloorDrain? right)
        {
            return EqualityComparer<FloorDrain?>.Default.Equals(left, right);
        }

        public static bool operator !=(FloorDrain? left, FloorDrain? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}