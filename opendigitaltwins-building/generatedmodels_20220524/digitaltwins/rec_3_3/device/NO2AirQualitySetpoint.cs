using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NO2AirQualitySetpoint : AirQualitySetpoint, IEquatable<NO2AirQualitySetpoint>
    {
        public NO2AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NO2AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NO2AirQualitySetpoint);
        }

        public bool Equals(NO2AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NO2AirQualitySetpoint? left, NO2AirQualitySetpoint? right)
        {
            return EqualityComparer<NO2AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(NO2AirQualitySetpoint? left, NO2AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}