using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireSuppressionSystem : FireProtectionSystem, IEquatable<FireSuppressionSystem>
    {
        public FireSuppressionSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireSuppressionSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireSuppressionSystem);
        }

        public bool Equals(FireSuppressionSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireSuppressionSystem? left, FireSuppressionSystem? right)
        {
            return EqualityComparer<FireSuppressionSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireSuppressionSystem? left, FireSuppressionSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}