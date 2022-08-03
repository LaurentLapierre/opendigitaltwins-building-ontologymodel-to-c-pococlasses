using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class PropertySet : Information, IEquatable<PropertySet>
    {
        public PropertySet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:PropertySet;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PropertySet);
        }

        public bool Equals(PropertySet? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PropertySet? left, PropertySet? right)
        {
            return EqualityComparer<PropertySet?>.Default.Equals(left, right);
        }

        public static bool operator !=(PropertySet? left, PropertySet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}