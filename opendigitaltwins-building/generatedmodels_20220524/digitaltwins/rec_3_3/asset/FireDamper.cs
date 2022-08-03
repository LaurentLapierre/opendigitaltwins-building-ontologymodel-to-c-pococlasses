using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireDamper : Damper, IEquatable<FireDamper>
    {
        public FireDamper()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireDamper;1";
        [JsonPropertyName("fireRating")]
        public double? FireRating { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireDamper);
        }

        public bool Equals(FireDamper? other)
        {
            return other is not null && base.Equals(other) && FireRating == other.FireRating;
        }

        public static bool operator ==(FireDamper? left, FireDamper? right)
        {
            return EqualityComparer<FireDamper?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireDamper? left, FireDamper? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), FireRating?.GetHashCode());
        }
    }
}