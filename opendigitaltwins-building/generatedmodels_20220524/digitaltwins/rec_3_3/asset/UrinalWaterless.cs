using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class UrinalWaterless : Urinal, IEquatable<UrinalWaterless>
    {
        public UrinalWaterless()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:UrinalWaterless;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as UrinalWaterless);
        }

        public bool Equals(UrinalWaterless? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(UrinalWaterless? left, UrinalWaterless? right)
        {
            return EqualityComparer<UrinalWaterless?>.Default.Equals(left, right);
        }

        public static bool operator !=(UrinalWaterless? left, UrinalWaterless? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}