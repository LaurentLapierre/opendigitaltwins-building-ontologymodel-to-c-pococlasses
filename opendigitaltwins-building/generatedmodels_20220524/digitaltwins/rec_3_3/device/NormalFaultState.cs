using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NormalFaultState : BinaryState, IEquatable<NormalFaultState>
    {
        public NormalFaultState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NormalFaultState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NormalFaultState);
        }

        public bool Equals(NormalFaultState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NormalFaultState? left, NormalFaultState? right)
        {
            return EqualityComparer<NormalFaultState?>.Default.Equals(left, right);
        }

        public static bool operator !=(NormalFaultState? left, NormalFaultState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}