using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.barrierasset
{

    public class BarrierAssetFromSpaceRelationship : Relationship<Space>, IEquatable<BarrierAssetFromSpaceRelationship>
    {
        public BarrierAssetFromSpaceRelationship()
        {
            Name = "fromSpace";
        }

        public BarrierAssetFromSpaceRelationship(BarrierAsset source, Space target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BarrierAssetFromSpaceRelationship);
        }

        public bool Equals(BarrierAssetFromSpaceRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(BarrierAssetFromSpaceRelationship? left, BarrierAssetFromSpaceRelationship? right)
        {
            return EqualityComparer<BarrierAssetFromSpaceRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(BarrierAssetFromSpaceRelationship? left, BarrierAssetFromSpaceRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as BarrierAssetFromSpaceRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}