using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.logicaldevice
{

    public class LogicalDeviceHasPartRelationship : Relationship<LogicalDevice>, IEquatable<LogicalDeviceHasPartRelationship>
    {
        public LogicalDeviceHasPartRelationship()
        {
            Name = "hasPart";
        }

        public LogicalDeviceHasPartRelationship(LogicalDevice source, LogicalDevice target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LogicalDeviceHasPartRelationship);
        }

        public bool Equals(LogicalDeviceHasPartRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(LogicalDeviceHasPartRelationship? left, LogicalDeviceHasPartRelationship? right)
        {
            return EqualityComparer<LogicalDeviceHasPartRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(LogicalDeviceHasPartRelationship? left, LogicalDeviceHasPartRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as LogicalDeviceHasPartRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}