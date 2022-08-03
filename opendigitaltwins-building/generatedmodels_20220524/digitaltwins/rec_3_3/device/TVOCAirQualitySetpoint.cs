using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class TVOCAirQualitySetpoint : AirQualitySetpoint, IEquatable<TVOCAirQualitySetpoint>
    {
        public TVOCAirQualitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:TVOCAirQualitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as TVOCAirQualitySetpoint);
        }

        public bool Equals(TVOCAirQualitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TVOCAirQualitySetpoint? left, TVOCAirQualitySetpoint? right)
        {
            return EqualityComparer<TVOCAirQualitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(TVOCAirQualitySetpoint? left, TVOCAirQualitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}