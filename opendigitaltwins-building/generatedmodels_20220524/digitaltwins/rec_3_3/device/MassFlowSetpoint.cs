using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class MassFlowSetpoint : FlowSetpoint, IEquatable<MassFlowSetpoint>
    {
        public MassFlowSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:MassFlowSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as MassFlowSetpoint);
        }

        public bool Equals(MassFlowSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(MassFlowSetpoint? left, MassFlowSetpoint? right)
        {
            return EqualityComparer<MassFlowSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(MassFlowSetpoint? left, MassFlowSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}