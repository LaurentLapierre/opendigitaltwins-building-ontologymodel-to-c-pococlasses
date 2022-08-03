using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AirQualityIndexSetpoint : AirQualitySetpoint, IEquatable<AirQualityIndexSetpoint>
    {
        public AirQualityIndexSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AirQualityIndexSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AirQualityIndexSetpoint);
        }

        public bool Equals(AirQualityIndexSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AirQualityIndexSetpoint? left, AirQualityIndexSetpoint? right)
        {
            return EqualityComparer<AirQualityIndexSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(AirQualityIndexSetpoint? left, AirQualityIndexSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}