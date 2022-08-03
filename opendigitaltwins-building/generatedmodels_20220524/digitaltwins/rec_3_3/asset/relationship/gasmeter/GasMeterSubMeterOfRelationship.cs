using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.gasmeter
{

    public class GasMeterSubMeterOfRelationship : Relationship<GasMeter>, IEquatable<GasMeterSubMeterOfRelationship>
    {
        public GasMeterSubMeterOfRelationship()
        {
            Name = "subMeterOf";
        }

        public GasMeterSubMeterOfRelationship(GasMeter source, GasMeter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as GasMeterSubMeterOfRelationship);
        }

        public bool Equals(GasMeterSubMeterOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(GasMeterSubMeterOfRelationship? left, GasMeterSubMeterOfRelationship? right)
        {
            return EqualityComparer<GasMeterSubMeterOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(GasMeterSubMeterOfRelationship? left, GasMeterSubMeterOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as GasMeterSubMeterOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}