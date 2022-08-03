using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingGlobeValve : PlumbingValve, IEquatable<PlumbingGlobeValve>
    {
        public PlumbingGlobeValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingGlobeValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingGlobeValve);
        }

        public bool Equals(PlumbingGlobeValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingGlobeValve? left, PlumbingGlobeValve? right)
        {
            return EqualityComparer<PlumbingGlobeValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingGlobeValve? left, PlumbingGlobeValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}