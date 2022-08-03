using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PositionState : PercentState, IEquatable<PositionState>
    {
        public PositionState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PositionState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PositionState);
        }

        public bool Equals(PositionState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PositionState? left, PositionState? right)
        {
            return EqualityComparer<PositionState?>.Default.Equals(left, right);
        }

        public static bool operator !=(PositionState? left, PositionState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}