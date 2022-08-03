using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class BackdraftDamper : Damper, IEquatable<BackdraftDamper>
    {
        public BackdraftDamper()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:BackdraftDamper;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as BackdraftDamper);
        }

        public bool Equals(BackdraftDamper? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(BackdraftDamper? left, BackdraftDamper? right)
        {
            return EqualityComparer<BackdraftDamper?>.Default.Equals(left, right);
        }

        public static bool operator !=(BackdraftDamper? left, BackdraftDamper? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}