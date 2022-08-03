using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.logicaldevice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class LogicalDevice : BasicDigitalTwin, IEquatable<LogicalDevice>, IEquatable<BasicDigitalTwin>
    {
        public LogicalDevice()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:LogicalDevice;1";
        [JsonPropertyName("IPAddress")]
        public string? IPAddress { get; set; }
        [JsonIgnore]
        public LogicalDeviceIsPartOfRelationshipCollection IsPartOf { get; set; } = new LogicalDeviceIsPartOfRelationshipCollection();
        [JsonIgnore]
        public LogicalDeviceHasPartRelationshipCollection HasPart { get; set; } = new LogicalDeviceHasPartRelationshipCollection();
        [JsonIgnore]
        public LogicalDeviceHasCapabilityRelationshipCollection HasCapability { get; set; } = new LogicalDeviceHasCapabilityRelationshipCollection();
        [JsonIgnore]
        public LogicalDeviceHostedByRelationshipCollection HostedBy { get; set; } = new LogicalDeviceHostedByRelationshipCollection();
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as LogicalDevice);
        }

        public bool Equals(LogicalDevice? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && IPAddress == other.IPAddress && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(LogicalDevice? left, LogicalDevice? right)
        {
            return EqualityComparer<LogicalDevice?>.Default.Equals(left, right);
        }

        public static bool operator !=(LogicalDevice? left, LogicalDevice? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), IPAddress?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as LogicalDevice) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}