using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DryBulbTemperatureSetpoint : TemperatureSetpoint, IEquatable<DryBulbTemperatureSetpoint>
    {
        public DryBulbTemperatureSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DryBulbTemperatureSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DryBulbTemperatureSetpoint);
        }

        public bool Equals(DryBulbTemperatureSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DryBulbTemperatureSetpoint? left, DryBulbTemperatureSetpoint? right)
        {
            return EqualityComparer<DryBulbTemperatureSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(DryBulbTemperatureSetpoint? left, DryBulbTemperatureSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}