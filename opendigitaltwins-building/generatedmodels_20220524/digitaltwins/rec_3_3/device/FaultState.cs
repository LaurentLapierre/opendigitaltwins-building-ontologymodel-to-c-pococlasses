using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FaultState : NormalFaultState, IEquatable<FaultState>
    {
        public FaultState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FaultState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FaultState);
        }

        public bool Equals(FaultState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FaultState? left, FaultState? right)
        {
            return EqualityComparer<FaultState?>.Default.Equals(left, right);
        }

        public static bool operator !=(FaultState? left, FaultState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}