using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM025AirQualitySetpoint : AirQualitySetpoint, IEquatable<PM025AirQualitySetpoint>
    {
        public PM025AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM025AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM025AirQualitySetpoint);
        }

        public bool Equals(PM025AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM025AirQualitySetpoint? left, PM025AirQualitySetpoint? right)
        {
            return EqualityComparer<PM025AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM025AirQualitySetpoint? left, PM025AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}