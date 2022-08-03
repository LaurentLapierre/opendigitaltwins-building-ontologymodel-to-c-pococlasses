using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerGlobeValve : SprinklerValve, IEquatable<SprinklerGlobeValve>
    {
        public SprinklerGlobeValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerGlobeValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerGlobeValve);
        }

        public bool Equals(SprinklerGlobeValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerGlobeValve? left, SprinklerGlobeValve? right)
        {
            return EqualityComparer<SprinklerGlobeValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerGlobeValve? left, SprinklerGlobeValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}