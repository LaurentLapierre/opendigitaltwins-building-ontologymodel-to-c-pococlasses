using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.capability;
using opendigitaltwins.building.digitaltwins.rec_3_3.device;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Capability : BasicDigitalTwin, IEquatable<Capability>, IEquatable<BasicDigitalTwin>
    {
        public Capability()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Capability;1";
        [JsonPropertyName("lastValueTime")]
        public DateTime? LastValueTime { get; set; }
        [JsonIgnore]
        public CapabilityServesRelationshipCollection Serves { get; set; } = new CapabilityServesRelationshipCollection();
        [JsonPropertyName("categorizationProperties")]
        public CapabilityPropertySet? CategorizationProperties { get; set; }
        [JsonIgnore]
        public CapabilityIsCapabilityOfRelationshipCollection IsCapabilityOf { get; set; } = new CapabilityIsCapabilityOfRelationshipCollection();
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Capability);
        }

        public bool Equals(Capability? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && LastValueTime == other.LastValueTime && CategorizationProperties == other.CategorizationProperties && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(Capability? left, Capability? right)
        {
            return EqualityComparer<Capability?>.Default.Equals(left, right);
        }

        public static bool operator !=(Capability? left, Capability? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), LastValueTime?.GetHashCode(), CategorizationProperties?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as Capability) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}