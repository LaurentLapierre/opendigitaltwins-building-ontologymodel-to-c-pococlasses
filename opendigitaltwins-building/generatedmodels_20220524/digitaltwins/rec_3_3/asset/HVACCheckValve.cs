using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACCheckValve : HVACValve, IEquatable<HVACCheckValve>
    {
        public HVACCheckValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACCheckValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACCheckValve);
        }

        public bool Equals(HVACCheckValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACCheckValve? left, HVACCheckValve? right)
        {
            return EqualityComparer<HVACCheckValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACCheckValve? left, HVACCheckValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}