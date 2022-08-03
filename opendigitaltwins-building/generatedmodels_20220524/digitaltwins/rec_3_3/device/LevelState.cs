using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LevelState : PercentState, IEquatable<LevelState>
    {
        public LevelState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LevelState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LevelState);
        }

        public bool Equals(LevelState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LevelState? left, LevelState? right)
        {
            return EqualityComparer<LevelState?>.Default.Equals(left, right);
        }

        public static bool operator !=(LevelState? left, LevelState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}