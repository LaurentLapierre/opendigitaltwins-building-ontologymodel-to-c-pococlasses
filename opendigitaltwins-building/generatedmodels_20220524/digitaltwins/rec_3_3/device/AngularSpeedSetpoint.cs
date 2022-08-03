using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AngularSpeedSetpoint : SpeedSetpoint, IEquatable<AngularSpeedSetpoint>
    {
        public AngularSpeedSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AngularSpeedSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as AngularSpeedSetpoint);
        }

        public bool Equals(AngularSpeedSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(AngularSpeedSetpoint? left, AngularSpeedSetpoint? right)
        {
            return EqualityComparer<AngularSpeedSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(AngularSpeedSetpoint? left, AngularSpeedSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}