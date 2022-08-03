using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NOxAirQualitySetpoint : AirQualitySetpoint, IEquatable<NOxAirQualitySetpoint>
    {
        public NOxAirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NOxAirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NOxAirQualitySetpoint);
        }

        public bool Equals(NOxAirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NOxAirQualitySetpoint? left, NOxAirQualitySetpoint? right)
        {
            return EqualityComparer<NOxAirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(NOxAirQualitySetpoint? left, NOxAirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}