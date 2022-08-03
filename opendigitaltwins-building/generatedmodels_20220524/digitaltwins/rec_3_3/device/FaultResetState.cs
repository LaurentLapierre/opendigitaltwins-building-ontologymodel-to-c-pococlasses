using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultResetState : ResetState, IEquatable<FaultResetState>
    {
        public FaultResetState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultResetState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultResetState);
        }

        public bool Equals(FaultResetState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultResetState? left, FaultResetState? right)
        {
            return EqualityComparer<FaultResetState?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultResetState? left, FaultResetState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}