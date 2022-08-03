using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VoltageImbalanceSetpoint : VoltageSetpoint, IEquatable<VoltageImbalanceSetpoint>
    {
        public VoltageImbalanceSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VoltageImbalanceSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as VoltageImbalanceSetpoint);
        }

        public bool Equals(VoltageImbalanceSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(VoltageImbalanceSetpoint? left, VoltageImbalanceSetpoint? right)
        {
            return EqualityComparer<VoltageImbalanceSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(VoltageImbalanceSetpoint? left, VoltageImbalanceSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}