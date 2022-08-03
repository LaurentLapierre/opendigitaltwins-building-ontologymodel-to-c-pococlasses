using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireProtectionSystem : System, IEquatable<FireProtectionSystem>
    {
        public FireProtectionSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireProtectionSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireProtectionSystem);
        }

        public bool Equals(FireProtectionSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireProtectionSystem? left, FireProtectionSystem? right)
        {
            return EqualityComparer<FireProtectionSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireProtectionSystem? left, FireProtectionSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}