using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NormalSetpoint : NormalFaultSetpoint, IEquatable<NormalSetpoint>
    {
        public NormalSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NormalSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NormalSetpoint);
        }

        public bool Equals(NormalSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NormalSetpoint? left, NormalSetpoint? right)
        {
            return EqualityComparer<NormalSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(NormalSetpoint? left, NormalSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}