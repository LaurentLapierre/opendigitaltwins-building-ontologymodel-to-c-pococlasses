using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM010AirQualitySetpoint : AirQualitySetpoint, IEquatable<PM010AirQualitySetpoint>
    {
        public PM010AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM010AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM010AirQualitySetpoint);
        }

        public bool Equals(PM010AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM010AirQualitySetpoint? left, PM010AirQualitySetpoint? right)
        {
            return EqualityComparer<PM010AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM010AirQualitySetpoint? left, PM010AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}