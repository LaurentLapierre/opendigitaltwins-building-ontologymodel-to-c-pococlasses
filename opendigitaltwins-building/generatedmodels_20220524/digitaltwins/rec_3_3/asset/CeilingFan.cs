using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class CeilingFan : HVACFan, IEquatable<CeilingFan>
    {
        public CeilingFan()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:CeilingFan;1";
        [JsonPropertyName("maxRotationSpeed")]
        public double? MaxRotationSpeed { get; set; }
        [JsonPropertyName("bladeDiameter")]
        public double? BladeDiameter { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as CeilingFan);
        }

        public bool Equals(CeilingFan? other)
        {
            return other is not null && base.Equals(other) && MaxRotationSpeed == other.MaxRotationSpeed && BladeDiameter == other.BladeDiameter;
        }

        public static bool operator ==(CeilingFan? left, CeilingFan? right)
        {
            return EqualityComparer<CeilingFan?>.Default.Equals(left, right);
        }

        public static bool operator !=(CeilingFan? left, CeilingFan? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), MaxRotationSpeed?.GetHashCode(), BladeDiameter?.GetHashCode());
        }
    }
}