using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingBackflowPreventer : PlumbingValve, IEquatable<PlumbingBackflowPreventer>
    {
        public PlumbingBackflowPreventer()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingBackflowPreventer;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingBackflowPreventer);
        }

        public bool Equals(PlumbingBackflowPreventer? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingBackflowPreventer? left, PlumbingBackflowPreventer? right)
        {
            return EqualityComparer<PlumbingBackflowPreventer?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingBackflowPreventer? left, PlumbingBackflowPreventer? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}