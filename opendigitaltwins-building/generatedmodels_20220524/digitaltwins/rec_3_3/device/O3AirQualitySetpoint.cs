using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class O3AirQualitySetpoint : AirQualitySetpoint, IEquatable<O3AirQualitySetpoint>
    {
        public O3AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:O3AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as O3AirQualitySetpoint);
        }

        public bool Equals(O3AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(O3AirQualitySetpoint? left, O3AirQualitySetpoint? right)
        {
            return EqualityComparer<O3AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(O3AirQualitySetpoint? left, O3AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}