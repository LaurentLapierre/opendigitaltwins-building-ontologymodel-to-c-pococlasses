using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business
{

    public class Role : BasicDigitalTwin, IEquatable<Role>, IEquatable<BasicDigitalTwin>
    {
        public Role()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:business:Role;1";
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Role);
        }

        public bool Equals(Role? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(Role? left, Role? right)
        {
            return EqualityComparer<Role?>.Default.Equals(left, right);
        }

        public static bool operator !=(Role? left, Role? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as Role) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}