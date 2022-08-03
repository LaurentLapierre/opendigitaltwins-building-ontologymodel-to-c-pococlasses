using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingPressureReducingStation : PlumbingValve, IEquatable<PlumbingPressureReducingStation>
    {
        public PlumbingPressureReducingStation()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingPressureReducingStation;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingPressureReducingStation);
        }

        public bool Equals(PlumbingPressureReducingStation? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingPressureReducingStation? left, PlumbingPressureReducingStation? right)
        {
            return EqualityComparer<PlumbingPressureReducingStation?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingPressureReducingStation? left, PlumbingPressureReducingStation? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}