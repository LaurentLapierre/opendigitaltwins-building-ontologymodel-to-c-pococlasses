using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class BasementLevel : Level, IEquatable<BasementLevel>
    {
        public BasementLevel()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:BasementLevel;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as BasementLevel);
        }

        public bool Equals(BasementLevel? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(BasementLevel? left, BasementLevel? right)
        {
            return EqualityComparer<BasementLevel?>.Default.Equals(left, right);
        }

        public static bool operator !=(BasementLevel? left, BasementLevel? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}