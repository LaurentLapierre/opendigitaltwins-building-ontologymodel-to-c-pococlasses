using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.logicaldevice
{

    public class LogicalDeviceHostedByRelationship : Relationship<Asset>, IEquatable<LogicalDeviceHostedByRelationship>
    {
        public LogicalDeviceHostedByRelationship()
        {
            Name = "hostedBy";
        }

        public LogicalDeviceHostedByRelationship(LogicalDevice source, Asset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LogicalDeviceHostedByRelationship);
        }

        public bool Equals(LogicalDeviceHostedByRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(LogicalDeviceHostedByRelationship? left, LogicalDeviceHostedByRelationship? right)
        {
            return EqualityComparer<LogicalDeviceHostedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(LogicalDeviceHostedByRelationship? left, LogicalDeviceHostedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as LogicalDeviceHostedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}