using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultResetSetpoint : ResetSetpoint, IEquatable<FaultResetSetpoint>
    {
        public FaultResetSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultResetSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultResetSetpoint);
        }

        public bool Equals(FaultResetSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultResetSetpoint? left, FaultResetSetpoint? right)
        {
            return EqualityComparer<FaultResetSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultResetSetpoint? left, FaultResetSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}