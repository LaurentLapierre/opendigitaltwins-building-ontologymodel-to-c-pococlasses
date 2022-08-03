using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DomesticWaterPump : PlumbingPump, IEquatable<DomesticWaterPump>
    {
        public DomesticWaterPump()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DomesticWaterPump;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DomesticWaterPump);
        }

        public bool Equals(DomesticWaterPump? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DomesticWaterPump? left, DomesticWaterPump? right)
        {
            return EqualityComparer<DomesticWaterPump?>.Default.Equals(left, right);
        }

        public static bool operator !=(DomesticWaterPump? left, DomesticWaterPump? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}