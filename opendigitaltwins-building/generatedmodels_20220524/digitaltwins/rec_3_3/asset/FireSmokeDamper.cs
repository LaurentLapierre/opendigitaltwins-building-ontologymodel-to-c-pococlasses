using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireSmokeDamper : FireDamper, IEquatable<FireSmokeDamper>
    {
        public FireSmokeDamper()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireSmokeDamper;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireSmokeDamper);
        }

        public bool Equals(FireSmokeDamper? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireSmokeDamper? left, FireSmokeDamper? right)
        {
            return EqualityComparer<FireSmokeDamper?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireSmokeDamper? left, FireSmokeDamper? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}