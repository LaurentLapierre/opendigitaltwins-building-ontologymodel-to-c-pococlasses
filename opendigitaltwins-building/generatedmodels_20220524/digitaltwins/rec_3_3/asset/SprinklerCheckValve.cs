using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerCheckValve : SprinklerValve, IEquatable<SprinklerCheckValve>
    {
        public SprinklerCheckValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerCheckValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerCheckValve);
        }

        public bool Equals(SprinklerCheckValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerCheckValve? left, SprinklerCheckValve? right)
        {
            return EqualityComparer<SprinklerCheckValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerCheckValve? left, SprinklerCheckValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}