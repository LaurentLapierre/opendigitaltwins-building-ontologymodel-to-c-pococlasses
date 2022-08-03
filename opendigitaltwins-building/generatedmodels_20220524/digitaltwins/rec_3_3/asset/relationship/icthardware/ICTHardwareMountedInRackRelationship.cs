using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.icthardware
{

    public class ICTHardwareMountedInRackRelationship : Relationship<ITRack>, IEquatable<ICTHardwareMountedInRackRelationship>
    {
        public ICTHardwareMountedInRackRelationship()
        {
            Name = "mountedInRack";
        }

        public ICTHardwareMountedInRackRelationship(ICTHardware source, ITRack target) : this()
        {
            InitializeFromTwins(source, target);
        }

        [JsonPropertyName("rackTopPosition")]
        public int? RackTopPosition { get; set; }
        [JsonPropertyName("rackBottomPosition")]
        public int? RackBottomPosition { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ICTHardwareMountedInRackRelationship);
        }

        public bool Equals(ICTHardwareMountedInRackRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name && RackTopPosition == other.RackTopPosition && RackBottomPosition == other.RackBottomPosition;
        }

        public static bool operator ==(ICTHardwareMountedInRackRelationship? left, ICTHardwareMountedInRackRelationship? right)
        {
            return EqualityComparer<ICTHardwareMountedInRackRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ICTHardwareMountedInRackRelationship? left, ICTHardwareMountedInRackRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode(), RackTopPosition?.GetHashCode(), RackBottomPosition?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ICTHardwareMountedInRackRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}