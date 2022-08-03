using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingPump : Pump, IEquatable<PlumbingPump>
    {
        public PlumbingPump()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingPump;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingPump);
        }

        public bool Equals(PlumbingPump? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingPump? left, PlumbingPump? right)
        {
            return EqualityComparer<PlumbingPump?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingPump? left, PlumbingPump? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}