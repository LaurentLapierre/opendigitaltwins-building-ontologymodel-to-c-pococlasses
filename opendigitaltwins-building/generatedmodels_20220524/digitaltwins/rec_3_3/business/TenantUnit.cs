using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.tenantunit;
using opendigitaltwins.building.digitaltwins.rec_3_3.addressing;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business
{

    public class TenantUnit : SpaceCollection, IEquatable<TenantUnit>
    {
        public TenantUnit()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:business:TenantUnit;1";
        [JsonIgnore]
        public TenantUnitIncludesRelationshipCollection Includes { get; set; } = new TenantUnitIncludesRelationshipCollection();
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as TenantUnit);
        }

        public bool Equals(TenantUnit? other)
        {
            return other is not null && base.Equals(other) && Address == other.Address;
        }

        public static bool operator ==(TenantUnit? left, TenantUnit? right)
        {
            return EqualityComparer<TenantUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(TenantUnit? left, TenantUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Address?.GetHashCode());
        }
    }
}