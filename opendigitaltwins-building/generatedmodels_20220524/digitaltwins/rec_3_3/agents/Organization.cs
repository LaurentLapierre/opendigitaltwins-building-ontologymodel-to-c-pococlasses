using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.agents.relationship.organization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents
{

    public class Organization : Agent, IEquatable<Organization>
    {
        public Organization()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:agents:Organization;1";
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }
        [JsonIgnore]
        public OrganizationIsPartOfRelationshipCollection IsPartOf { get; set; } = new OrganizationIsPartOfRelationshipCollection();
        [JsonIgnore]
        public OrganizationHasPartRelationshipCollection HasPart { get; set; } = new OrganizationHasPartRelationshipCollection();
        [JsonIgnore]
        public OrganizationHasMemberRelationshipCollection HasMember { get; set; } = new OrganizationHasMemberRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Organization);
        }

        public bool Equals(Organization? other)
        {
            return other is not null && base.Equals(other) && Logo == other.Logo;
        }

        public static bool operator ==(Organization? left, Organization? right)
        {
            return EqualityComparer<Organization?>.Default.Equals(left, right);
        }

        public static bool operator !=(Organization? left, Organization? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Logo?.GetHashCode());
        }
    }
}