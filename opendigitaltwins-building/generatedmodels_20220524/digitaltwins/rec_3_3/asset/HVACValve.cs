using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACValve : Valve, IEquatable<HVACValve>
    {
        public HVACValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACValve);
        }

        public bool Equals(HVACValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACValve? left, HVACValve? right)
        {
            return EqualityComparer<HVACValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACValve? left, HVACValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}