using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingValve : Valve, IEquatable<PlumbingValve>
    {
        public PlumbingValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingValve);
        }

        public bool Equals(PlumbingValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingValve? left, PlumbingValve? right)
        {
            return EqualityComparer<PlumbingValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingValve? left, PlumbingValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}