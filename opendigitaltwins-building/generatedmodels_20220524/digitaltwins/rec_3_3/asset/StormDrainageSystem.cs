using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class StormDrainageSystem : DrainageSystem, IEquatable<StormDrainageSystem>
    {
        public StormDrainageSystem()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:StormDrainageSystem;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StormDrainageSystem);
        }

        public bool Equals(StormDrainageSystem? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StormDrainageSystem? left, StormDrainageSystem? right)
        {
            return EqualityComparer<StormDrainageSystem?>.Default.Equals(left, right);
        }

        public static bool operator !=(StormDrainageSystem? left, StormDrainageSystem? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}