using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OccupancySetpoint : PresenceSetpoint, IEquatable<OccupancySetpoint>
    {
        public OccupancySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OccupancySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OccupancySetpoint);
        }

        public bool Equals(OccupancySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OccupancySetpoint? left, OccupancySetpoint? right)
        {
            return EqualityComparer<OccupancySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(OccupancySetpoint? left, OccupancySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}