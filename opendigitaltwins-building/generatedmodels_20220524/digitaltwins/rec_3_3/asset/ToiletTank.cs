using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ToiletTank : Toilet, IEquatable<ToiletTank>
    {
        public ToiletTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ToiletTank;1";
        [JsonPropertyName("flushingType")]
        public ToiletTankFlushingType? FlushingType { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ToiletTank);
        }

        public bool Equals(ToiletTank? other)
        {
            return other is not null && base.Equals(other) && FlushingType == other.FlushingType;
        }

        public static bool operator ==(ToiletTank? left, ToiletTank? right)
        {
            return EqualityComparer<ToiletTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToiletTank? left, ToiletTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), FlushingType?.GetHashCode());
        }
    }
}