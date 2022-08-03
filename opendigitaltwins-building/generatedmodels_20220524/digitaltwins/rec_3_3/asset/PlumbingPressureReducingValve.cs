using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingPressureReducingValve : PlumbingValve, IEquatable<PlumbingPressureReducingValve>
    {
        public PlumbingPressureReducingValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingPressureReducingValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingPressureReducingValve);
        }

        public bool Equals(PlumbingPressureReducingValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingPressureReducingValve? left, PlumbingPressureReducingValve? right)
        {
            return EqualityComparer<PlumbingPressureReducingValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingPressureReducingValve? left, PlumbingPressureReducingValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}