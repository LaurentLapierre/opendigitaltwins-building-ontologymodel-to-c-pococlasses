using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACGlobeValve : HVACValve, IEquatable<HVACGlobeValve>
    {
        public HVACGlobeValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACGlobeValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACGlobeValve);
        }

        public bool Equals(HVACGlobeValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACGlobeValve? left, HVACGlobeValve? right)
        {
            return EqualityComparer<HVACGlobeValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACGlobeValve? left, HVACGlobeValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}