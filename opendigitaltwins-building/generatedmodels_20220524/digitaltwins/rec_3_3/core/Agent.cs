using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.agent;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Agent : BasicDigitalTwin, IEquatable<Agent>, IEquatable<BasicDigitalTwin>
    {
        public Agent()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Agent;1";
        [JsonIgnore]
        public AgentHasRoleRelationshipCollection HasRole { get; set; } = new AgentHasRoleRelationshipCollection();
        [JsonIgnore]
        public AgentOwnsRelationshipCollection Owns { get; set; } = new AgentOwnsRelationshipCollection();
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Agent);
        }

        public bool Equals(Agent? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(Agent? left, Agent? right)
        {
            return EqualityComparer<Agent?>.Default.Equals(left, right);
        }

        public static bool operator !=(Agent? left, Agent? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as Agent) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}