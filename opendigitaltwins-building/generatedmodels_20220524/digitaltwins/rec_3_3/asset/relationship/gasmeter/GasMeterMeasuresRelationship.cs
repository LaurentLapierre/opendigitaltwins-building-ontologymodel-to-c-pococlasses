using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.gasmeter
{

    public class GasMeterMeasuresRelationship : Relationship<BasicDigitalTwin>, IEquatable<GasMeterMeasuresRelationship>
    {
        public GasMeterMeasuresRelationship()
        {
            Name = "measures";
        }

        public GasMeterMeasuresRelationship(GasMeter source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as GasMeterMeasuresRelationship);
        }

        public bool Equals(GasMeterMeasuresRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(GasMeterMeasuresRelationship? left, GasMeterMeasuresRelationship? right)
        {
            return EqualityComparer<GasMeterMeasuresRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(GasMeterMeasuresRelationship? left, GasMeterMeasuresRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as GasMeterMeasuresRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}