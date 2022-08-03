using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StopSetpoint : StartStopSetpoint, IEquatable<StopSetpoint>
    {
        public StopSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StopSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StopSetpoint);
        }

        public bool Equals(StopSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StopSetpoint? left, StopSetpoint? right)
        {
            return EqualityComparer<StopSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(StopSetpoint? left, StopSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}