using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultSetpoint : NormalFaultSetpoint, IEquatable<FaultSetpoint>
    {
        public FaultSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultSetpoint);
        }

        public bool Equals(FaultSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultSetpoint? left, FaultSetpoint? right)
        {
            return EqualityComparer<FaultSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultSetpoint? left, FaultSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}