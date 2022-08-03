using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AccessReader : AccessControlEquipment, IEquatable<AccessReader>
    {
        public AccessReader()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AccessReader;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AccessReader);
        }

        public bool Equals(AccessReader? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AccessReader? left, AccessReader? right)
        {
            return EqualityComparer<AccessReader?>.Default.Equals(left, right);
        }

        public static bool operator !=(AccessReader? left, AccessReader? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}