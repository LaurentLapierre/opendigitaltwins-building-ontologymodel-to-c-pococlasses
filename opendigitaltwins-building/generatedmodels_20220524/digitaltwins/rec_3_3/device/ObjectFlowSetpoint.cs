using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ObjectFlowSetpoint : FlowSetpoint, IEquatable<ObjectFlowSetpoint>
    {
        public ObjectFlowSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ObjectFlowSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ObjectFlowSetpoint);
        }

        public bool Equals(ObjectFlowSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(ObjectFlowSetpoint? left, ObjectFlowSetpoint? right)
        {
            return EqualityComparer<ObjectFlowSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(ObjectFlowSetpoint? left, ObjectFlowSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}