using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class StairPressurizationFan : HVACFan, IEquatable<StairPressurizationFan>
    {
        public StairPressurizationFan()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:StairPressurizationFan;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StairPressurizationFan);
        }

        public bool Equals(StairPressurizationFan? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StairPressurizationFan? left, StairPressurizationFan? right)
        {
            return EqualityComparer<StairPressurizationFan?>.Default.Equals(left, right);
        }

        public static bool operator !=(StairPressurizationFan? left, StairPressurizationFan? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}