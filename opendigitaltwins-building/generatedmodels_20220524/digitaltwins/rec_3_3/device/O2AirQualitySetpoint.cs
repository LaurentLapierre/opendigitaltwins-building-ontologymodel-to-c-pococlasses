using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class O2AirQualitySetpoint : AirQualitySetpoint, IEquatable<O2AirQualitySetpoint>
    {
        public O2AirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:O2AirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as O2AirQualitySetpoint);
        }

        public bool Equals(O2AirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(O2AirQualitySetpoint? left, O2AirQualitySetpoint? right)
        {
            return EqualityComparer<O2AirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(O2AirQualitySetpoint? left, O2AirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}