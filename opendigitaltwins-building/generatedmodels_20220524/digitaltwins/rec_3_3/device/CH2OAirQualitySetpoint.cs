using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CH2OAirQualitySetpoint : AirQualitySetpoint, IEquatable<CH2OAirQualitySetpoint>
    {
        public CH2OAirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CH2OAirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CH2OAirQualitySetpoint);
        }

        public bool Equals(CH2OAirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CH2OAirQualitySetpoint? left, CH2OAirQualitySetpoint? right)
        {
            return EqualityComparer<CH2OAirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(CH2OAirQualitySetpoint? left, CH2OAirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}