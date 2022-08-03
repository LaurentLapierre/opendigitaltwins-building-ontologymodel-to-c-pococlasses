using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Level : Space, IEquatable<Level>
    {
        public Level()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Level;1";
        [JsonPropertyName("levelNumber")]
        public int? LevelNumber { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Level);
        }

        public bool Equals(Level? other)
        {
            return other is not null && base.Equals(other) && LevelNumber == other.LevelNumber;
        }

        public static bool operator ==(Level? left, Level? right)
        {
            return EqualityComparer<Level?>.Default.Equals(left, right);
        }

        public static bool operator !=(Level? left, Level? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LevelNumber?.GetHashCode());
        }
    }
}