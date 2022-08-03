using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StopState : StartStopState, IEquatable<StopState>
    {
        public StopState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StopState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StopState);
        }

        public bool Equals(StopState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StopState? left, StopState? right)
        {
            return EqualityComparer<StopState?>.Default.Equals(left, right);
        }

        public static bool operator !=(StopState? left, StopState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}