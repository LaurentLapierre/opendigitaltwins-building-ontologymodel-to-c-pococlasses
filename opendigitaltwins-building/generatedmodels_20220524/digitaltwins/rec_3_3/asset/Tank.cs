using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Tank : Component, IEquatable<Tank>
    {
        public Tank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Tank;1";
        [JsonPropertyName("tankCapacity")]
        public double? TankCapacity { get; set; }
        [JsonPropertyName("systemPressure")]
        public double? SystemPressure { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Tank);
        }

        public bool Equals(Tank? other)
        {
            return other is not null && base.Equals(other) && TankCapacity == other.TankCapacity && SystemPressure == other.SystemPressure;
        }

        public static bool operator ==(Tank? left, Tank? right)
        {
            return EqualityComparer<Tank?>.Default.Equals(left, right);
        }

        public static bool operator !=(Tank? left, Tank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), TankCapacity?.GetHashCode(), SystemPressure?.GetHashCode());
        }
    }
}