using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ModeState : MultiState, IEquatable<ModeState>
    {
        public ModeState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ModeState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ModeState);
        }

        public bool Equals(ModeState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ModeState? left, ModeState? right)
        {
            return EqualityComparer<ModeState?>.Default.Equals(left, right);
        }

        public static bool operator !=(ModeState? left, ModeState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}