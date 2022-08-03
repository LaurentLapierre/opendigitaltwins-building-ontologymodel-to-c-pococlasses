using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OccupancyState : PresenceState, IEquatable<OccupancyState>
    {
        public OccupancyState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OccupancyState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OccupancyState);
        }

        public bool Equals(OccupancyState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OccupancyState? left, OccupancyState? right)
        {
            return EqualityComparer<OccupancyState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OccupancyState? left, OccupancyState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}