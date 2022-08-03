using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.realestate;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class RealEstate : SpaceCollection, IEquatable<RealEstate>
    {
        public RealEstate()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:RealEstate;1";
        [JsonPropertyName("propertyRegisterDesignation")]
        public string? PropertyRegisterDesignation { get; set; }
        [JsonIgnore]
        public RealEstateOwnedByRelationshipCollection OwnedBy { get; set; } = new RealEstateOwnedByRelationshipCollection();
        [JsonIgnore]
        public RealEstateIncludesRelationshipCollection Includes { get; set; } = new RealEstateIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as RealEstate);
        }

        public bool Equals(RealEstate? other)
        {
            return other is not null && base.Equals(other) && PropertyRegisterDesignation == other.PropertyRegisterDesignation;
        }

        public static bool operator ==(RealEstate? left, RealEstate? right)
        {
            return EqualityComparer<RealEstate?>.Default.Equals(left, right);
        }

        public static bool operator !=(RealEstate? left, RealEstate? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PropertyRegisterDesignation?.GetHashCode());
        }
    }
}