using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ConductanceSetpoint : QuantitySetpoint, IEquatable<ConductanceSetpoint>
    {
        public ConductanceSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ConductanceSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ConductanceSetpoint);
        }

        public bool Equals(ConductanceSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(ConductanceSetpoint? left, ConductanceSetpoint? right)
        {
            return EqualityComparer<ConductanceSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ConductanceSetpoint? left, ConductanceSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}