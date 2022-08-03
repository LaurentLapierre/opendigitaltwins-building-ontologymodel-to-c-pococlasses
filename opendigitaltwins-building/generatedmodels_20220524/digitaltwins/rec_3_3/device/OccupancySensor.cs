using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OccupancySensor : PresenceSensor, IEquatable<OccupancySensor>
    {
        public OccupancySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OccupancySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OccupancySensor);
        }

        public bool Equals(OccupancySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OccupancySensor? left, OccupancySensor? right)
        {
            return EqualityComparer<OccupancySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(OccupancySensor? left, OccupancySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}