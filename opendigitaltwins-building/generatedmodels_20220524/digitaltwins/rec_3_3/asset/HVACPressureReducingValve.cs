using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACPressureReducingValve : HVACValve, IEquatable<HVACPressureReducingValve>
    {
        public HVACPressureReducingValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACPressureReducingValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACPressureReducingValve);
        }

        public bool Equals(HVACPressureReducingValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACPressureReducingValve? left, HVACPressureReducingValve? right)
        {
            return EqualityComparer<HVACPressureReducingValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACPressureReducingValve? left, HVACPressureReducingValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}