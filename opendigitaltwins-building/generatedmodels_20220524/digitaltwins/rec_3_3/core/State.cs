using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class State : Capability, IEquatable<State>
    {
        public State()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:State;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as State);
        }

        public bool Equals(State? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(State? left, State? right)
        {
            return EqualityComparer<State?>.Default.Equals(left, right);
        }

        public static bool operator !=(State? left, State? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}