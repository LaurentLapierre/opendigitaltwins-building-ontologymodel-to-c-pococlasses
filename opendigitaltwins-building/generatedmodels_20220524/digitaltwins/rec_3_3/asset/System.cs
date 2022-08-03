using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.system;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class System : EquipmentCollection, IEquatable<System>
    {
        public System()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:System;1";
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
        [JsonPropertyName("service")]
        public SystemService? Service { get; set; }
        [JsonIgnore]
        public SystemIsPartOfRelationshipCollection IsPartOf { get; set; } = new SystemIsPartOfRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as System);
        }

        public bool Equals(System? other)
        {
            return other is not null && base.Equals(other) && Comment == other.Comment && Service == other.Service;
        }

        public static bool operator ==(System? left, System? right)
        {
            return EqualityComparer<System?>.Default.Equals(left, right);
        }

        public static bool operator !=(System? left, System? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Comment?.GetHashCode(), Service?.GetHashCode());
        }
    }
}