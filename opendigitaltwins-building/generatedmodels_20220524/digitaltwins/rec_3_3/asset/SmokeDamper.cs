using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SmokeDamper : Damper, IEquatable<SmokeDamper>
    {
        public SmokeDamper()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SmokeDamper;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SmokeDamper);
        }

        public bool Equals(SmokeDamper? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SmokeDamper? left, SmokeDamper? right)
        {
            return EqualityComparer<SmokeDamper?>.Default.Equals(left, right);
        }

        public static bool operator !=(SmokeDamper? left, SmokeDamper? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}