using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM10AirQualitySetpoint : AirQualitySetpoint, IEquatable<PM10AirQualitySetpoint>
    {
        public PM10AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM10AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM10AirQualitySetpoint);
        }

        public bool Equals(PM10AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM10AirQualitySetpoint? left, PM10AirQualitySetpoint? right)
        {
            return EqualityComparer<PM10AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM10AirQualitySetpoint? left, PM10AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}