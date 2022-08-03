using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartStopSetpoint : BinarySetpoint, IEquatable<StartStopSetpoint>
    {
        public StartStopSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartStopSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartStopSetpoint);
        }

        public bool Equals(StartStopSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartStopSetpoint? left, StartStopSetpoint? right)
        {
            return EqualityComparer<StartStopSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartStopSetpoint? left, StartStopSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}