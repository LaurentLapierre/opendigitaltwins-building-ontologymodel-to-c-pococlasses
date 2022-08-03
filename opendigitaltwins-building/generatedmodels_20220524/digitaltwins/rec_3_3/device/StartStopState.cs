using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartStopState : BinaryState, IEquatable<StartStopState>
    {
        public StartStopState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartStopState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartStopState);
        }

        public bool Equals(StartStopState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartStopState? left, StartStopState? right)
        {
            return EqualityComparer<StartStopState?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartStopState? left, StartStopState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}