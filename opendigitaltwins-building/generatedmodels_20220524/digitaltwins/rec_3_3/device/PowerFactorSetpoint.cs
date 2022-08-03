using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PowerFactorSetpoint : QuantitySetpoint, IEquatable<PowerFactorSetpoint>
    {
        public PowerFactorSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PowerFactorSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as PowerFactorSetpoint);
        }

        public bool Equals(PowerFactorSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(PowerFactorSetpoint? left, PowerFactorSetpoint? right)
        {
            return EqualityComparer<PowerFactorSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PowerFactorSetpoint? left, PowerFactorSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}