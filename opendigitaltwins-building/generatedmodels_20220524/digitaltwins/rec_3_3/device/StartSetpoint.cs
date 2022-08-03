using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartSetpoint : StartStopSetpoint, IEquatable<StartSetpoint>
    {
        public StartSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartSetpoint);
        }

        public bool Equals(StartSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartSetpoint? left, StartSetpoint? right)
        {
            return EqualityComparer<StartSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartSetpoint? left, StartSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}