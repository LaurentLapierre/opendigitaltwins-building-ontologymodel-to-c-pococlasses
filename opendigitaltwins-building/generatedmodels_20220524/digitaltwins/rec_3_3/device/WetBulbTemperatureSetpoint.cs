using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class WetBulbTemperatureSetpoint : TemperatureSetpoint, IEquatable<WetBulbTemperatureSetpoint>
    {
        public WetBulbTemperatureSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:WetBulbTemperatureSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as WetBulbTemperatureSetpoint);
        }

        public bool Equals(WetBulbTemperatureSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WetBulbTemperatureSetpoint? left, WetBulbTemperatureSetpoint? right)
        {
            return EqualityComparer<WetBulbTemperatureSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(WetBulbTemperatureSetpoint? left, WetBulbTemperatureSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}