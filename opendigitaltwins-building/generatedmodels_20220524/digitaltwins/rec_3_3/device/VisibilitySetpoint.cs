using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VisibilitySetpoint : DistanceSetpoint, IEquatable<VisibilitySetpoint>
    {
        public VisibilitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VisibilitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VisibilitySetpoint);
        }

        public bool Equals(VisibilitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VisibilitySetpoint? left, VisibilitySetpoint? right)
        {
            return EqualityComparer<VisibilitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(VisibilitySetpoint? left, VisibilitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}