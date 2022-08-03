using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class InferredOccupancySetpoint : OccupancySetpoint, IEquatable<InferredOccupancySetpoint>
    {
        public InferredOccupancySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:InferredOccupancySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as InferredOccupancySetpoint);
        }

        public bool Equals(InferredOccupancySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(InferredOccupancySetpoint? left, InferredOccupancySetpoint? right)
        {
            return EqualityComparer<InferredOccupancySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(InferredOccupancySetpoint? left, InferredOccupancySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}