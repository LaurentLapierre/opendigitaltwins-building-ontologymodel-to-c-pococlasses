using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerSystem : FireSuppressionSystem, IEquatable<SprinklerSystem>
    {
        public SprinklerSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerSystem);
        }

        public bool Equals(SprinklerSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerSystem? left, SprinklerSystem? right)
        {
            return EqualityComparer<SprinklerSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerSystem? left, SprinklerSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}