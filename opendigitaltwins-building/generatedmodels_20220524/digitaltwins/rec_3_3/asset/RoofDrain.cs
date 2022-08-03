using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class RoofDrain : Drain, IEquatable<RoofDrain>
    {
        public RoofDrain()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:RoofDrain;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as RoofDrain);
        }

        public bool Equals(RoofDrain? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(RoofDrain? left, RoofDrain? right)
        {
            return EqualityComparer<RoofDrain?>.Default.Equals(left, right);
        }

        public static bool operator !=(RoofDrain? left, RoofDrain? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}