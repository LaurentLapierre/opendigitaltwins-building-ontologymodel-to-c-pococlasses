using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACPressureReducingStation : HVACValve, IEquatable<HVACPressureReducingStation>
    {
        public HVACPressureReducingStation()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACPressureReducingStation;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACPressureReducingStation);
        }

        public bool Equals(HVACPressureReducingStation? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACPressureReducingStation? left, HVACPressureReducingStation? right)
        {
            return EqualityComparer<HVACPressureReducingStation?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACPressureReducingStation? left, HVACPressureReducingStation? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}