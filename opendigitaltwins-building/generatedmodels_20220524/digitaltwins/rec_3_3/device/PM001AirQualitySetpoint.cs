using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM001AirQualitySetpoint : AirQualitySetpoint, IEquatable<PM001AirQualitySetpoint>
    {
        public PM001AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM001AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM001AirQualitySetpoint);
        }

        public bool Equals(PM001AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM001AirQualitySetpoint? left, PM001AirQualitySetpoint? right)
        {
            return EqualityComparer<PM001AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM001AirQualitySetpoint? left, PM001AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}