using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartState : StartStopState, IEquatable<StartState>
    {
        public StartState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartState);
        }

        public bool Equals(StartState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartState? left, StartState? right)
        {
            return EqualityComparer<StartState?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartState? left, StartState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}