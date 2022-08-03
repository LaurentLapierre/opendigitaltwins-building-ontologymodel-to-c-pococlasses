using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CO2AirQualitySetpoint : AirQualitySetpoint, IEquatable<CO2AirQualitySetpoint>
    {
        public CO2AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CO2AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CO2AirQualitySetpoint);
        }

        public bool Equals(CO2AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CO2AirQualitySetpoint? left, CO2AirQualitySetpoint? right)
        {
            return EqualityComparer<CO2AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(CO2AirQualitySetpoint? left, CO2AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}