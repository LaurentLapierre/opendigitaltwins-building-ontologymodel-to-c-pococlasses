using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class InferredOccupancySensor : OccupancySensor, IEquatable<InferredOccupancySensor>
    {
        public InferredOccupancySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:InferredOccupancySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as InferredOccupancySensor);
        }

        public bool Equals(InferredOccupancySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(InferredOccupancySensor? left, InferredOccupancySensor? right)
        {
            return EqualityComparer<InferredOccupancySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(InferredOccupancySensor? left, InferredOccupancySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}