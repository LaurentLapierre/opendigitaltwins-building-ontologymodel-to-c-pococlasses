using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.lease;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business
{

    public class Lease : Event, IEquatable<Lease>
    {
        public Lease()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:business:Lease;1";
        [JsonPropertyName("leaseStart")]
        public DateTime? LeaseStart { get; set; }
        [JsonPropertyName("leaseEnd")]
        public DateTime? LeaseEnd { get; set; }
        [JsonIgnore]
        public LeaseRegulatedByRelationshipCollection RegulatedBy { get; set; } = new LeaseRegulatedByRelationshipCollection();
        [JsonIgnore]
        public LeaseLeasorRelationshipCollection Leasor { get; set; } = new LeaseLeasorRelationshipCollection();
        [JsonIgnore]
        public LeaseLeaseeRelationshipCollection Leasee { get; set; } = new LeaseLeaseeRelationshipCollection();
        [JsonIgnore]
        public LeaseLeaseOfRelationshipCollection LeaseOf { get; set; } = new LeaseLeaseOfRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Lease);
        }

        public bool Equals(Lease? other)
        {
            return other is not null && base.Equals(other) && LeaseStart == other.LeaseStart && LeaseEnd == other.LeaseEnd;
        }

        public static bool operator ==(Lease? left, Lease? right)
        {
            return EqualityComparer<Lease?>.Default.Equals(left, right);
        }

        public static bool operator !=(Lease? left, Lease? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LeaseStart?.GetHashCode(), LeaseEnd?.GetHashCode());
        }
    }
}