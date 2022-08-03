using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Document : BasicDigitalTwin, IEquatable<Document>, IEquatable<BasicDigitalTwin>
    {
        public Document()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Document;1";
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Document);
        }

        public bool Equals(Document? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && Url == other.Url && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(Document? left, Document? right)
        {
            return EqualityComparer<Document?>.Default.Equals(left, right);
        }

        public static bool operator !=(Document? left, Document? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), Url?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as Document) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}