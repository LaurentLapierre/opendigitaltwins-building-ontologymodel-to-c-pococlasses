using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NormalFaultSetpoint : BinarySetpoint, IEquatable<NormalFaultSetpoint>
    {
        public NormalFaultSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NormalFaultSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NormalFaultSetpoint);
        }

        public bool Equals(NormalFaultSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NormalFaultSetpoint? left, NormalFaultSetpoint? right)
        {
            return EqualityComparer<NormalFaultSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(NormalFaultSetpoint? left, NormalFaultSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}