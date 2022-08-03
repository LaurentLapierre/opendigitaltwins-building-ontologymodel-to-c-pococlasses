using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class LightingSystem : System, IEquatable<LightingSystem>
    {
        public LightingSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:LightingSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LightingSystem);
        }

        public bool Equals(LightingSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LightingSystem? left, LightingSystem? right)
        {
            return EqualityComparer<LightingSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(LightingSystem? left, LightingSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}