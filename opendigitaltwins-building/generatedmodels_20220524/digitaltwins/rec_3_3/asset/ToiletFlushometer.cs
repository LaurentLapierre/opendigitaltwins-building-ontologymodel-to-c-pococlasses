using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ToiletFlushometer : Toilet, IEquatable<ToiletFlushometer>
    {
        public ToiletFlushometer()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ToiletFlushometer;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ToiletFlushometer);
        }

        public bool Equals(ToiletFlushometer? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ToiletFlushometer? left, ToiletFlushometer? right)
        {
            return EqualityComparer<ToiletFlushometer?>.Default.Equals(left, right);
        }

        public static bool operator !=(ToiletFlushometer? left, ToiletFlushometer? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}