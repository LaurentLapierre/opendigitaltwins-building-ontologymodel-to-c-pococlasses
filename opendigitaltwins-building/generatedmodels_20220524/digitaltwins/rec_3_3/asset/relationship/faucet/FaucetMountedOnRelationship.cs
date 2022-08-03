using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.faucet
{

    public class FaucetMountedOnRelationship : Relationship<Sink>, IEquatable<FaucetMountedOnRelationship>
    {
        public FaucetMountedOnRelationship()
        {
            Name = "mountedOn";
        }

        public FaucetMountedOnRelationship(Faucet source, Sink target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FaucetMountedOnRelationship);
        }

        public bool Equals(FaucetMountedOnRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FaucetMountedOnRelationship? left, FaucetMountedOnRelationship? right)
        {
            return EqualityComparer<FaucetMountedOnRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaucetMountedOnRelationship? left, FaucetMountedOnRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FaucetMountedOnRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}