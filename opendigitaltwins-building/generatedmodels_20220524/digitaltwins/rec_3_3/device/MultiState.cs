using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class MultiState : State, IEquatable<MultiState>
    {
        public MultiState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:MultiState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MultiState);
        }

        public bool Equals(MultiState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MultiState? left, MultiState? right)
        {
            return EqualityComparer<MultiState?>.Default.Equals(left, right);
        }

        public static bool operator !=(MultiState? left, MultiState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}