using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FlowSetpoint : QuantitySetpoint, IEquatable<FlowSetpoint>
    {
        public FlowSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FlowSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FlowSetpoint);
        }

        public bool Equals(FlowSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FlowSetpoint? left, FlowSetpoint? right)
        {
            return EqualityComparer<FlowSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(FlowSetpoint? left, FlowSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}