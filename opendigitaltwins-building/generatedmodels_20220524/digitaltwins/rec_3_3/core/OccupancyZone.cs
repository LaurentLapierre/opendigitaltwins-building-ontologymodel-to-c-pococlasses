using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class OccupancyZone : Zone, IEquatable<OccupancyZone>
    {
        public OccupancyZone()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:OccupancyZone;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OccupancyZone);
        }

        public bool Equals(OccupancyZone? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OccupancyZone? left, OccupancyZone? right)
        {
            return EqualityComparer<OccupancyZone?>.Default.Equals(left, right);
        }

        public static bool operator !=(OccupancyZone? left, OccupancyZone? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}