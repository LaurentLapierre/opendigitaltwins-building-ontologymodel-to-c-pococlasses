using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerBackflowPreventer : SprinklerValve, IEquatable<SprinklerBackflowPreventer>
    {
        public SprinklerBackflowPreventer()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerBackflowPreventer;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerBackflowPreventer);
        }

        public bool Equals(SprinklerBackflowPreventer? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerBackflowPreventer? left, SprinklerBackflowPreventer? right)
        {
            return EqualityComparer<SprinklerBackflowPreventer?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerBackflowPreventer? left, SprinklerBackflowPreventer? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}