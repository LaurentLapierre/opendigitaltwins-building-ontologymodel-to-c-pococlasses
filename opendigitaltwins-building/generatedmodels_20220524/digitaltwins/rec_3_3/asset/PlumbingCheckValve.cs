using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingCheckValve : PlumbingValve, IEquatable<PlumbingCheckValve>
    {
        public PlumbingCheckValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingCheckValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingCheckValve);
        }

        public bool Equals(PlumbingCheckValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingCheckValve? left, PlumbingCheckValve? right)
        {
            return EqualityComparer<PlumbingCheckValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingCheckValve? left, PlumbingCheckValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}