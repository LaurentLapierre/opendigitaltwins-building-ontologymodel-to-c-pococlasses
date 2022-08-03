using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class SO2AirQualitySetpoint : AirQualitySetpoint, IEquatable<SO2AirQualitySetpoint>
    {
        public SO2AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:SO2AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SO2AirQualitySetpoint);
        }

        public bool Equals(SO2AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SO2AirQualitySetpoint? left, SO2AirQualitySetpoint? right)
        {
            return EqualityComparer<SO2AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(SO2AirQualitySetpoint? left, SO2AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}